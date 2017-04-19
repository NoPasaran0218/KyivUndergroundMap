using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Metro.BL;
using System.Windows.Media.Imaging;

namespace testTask1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Metropoliten _MainMetropoliten = new Metropoliten();
        public Stantion _StartStation { get; private set; }
        public Stantion _FinishStation { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateRoute(object sender, RoutedEventArgs e)
        {
            if (_StartStation == _FinishStation)
                return;
            if (BackgroundCanvas.Children.Count>1)
            {
                UIElement[] CopyCanvasChildren = new UIElement[BackgroundCanvas.Children.Count];
                BackgroundCanvas.Children.CopyTo(CopyCanvasChildren, 0);
                BackgroundCanvas.Children.Clear();
                for (int i = 0; i < CopyCanvasChildren.Count() - 1; i++)
                    BackgroundCanvas.Children.Add(CopyCanvasChildren[i]);
            }

            PolyLineSegment polyLineSegment = new PolyLineSegment();
            polyLineSegment.IsStroked = true;
            PointCollection points = new PointCollection();

            if (_StartStation == null || _FinishStation == null)
                return;

            List<Stantion> routeStantions = _MainMetropoliten.GetRoute(_StartStation._StantionId, _FinishStation._StantionId);

            points.Add(new Point(routeStantions[0]._LeftProportion * grid.ActualWidth, routeStantions[0]._TopProportion * grid.ActualHeight));
            for (int i = 1; i < routeStantions.Count; i++)
            {
                if ((routeStantions[i-1]._StantionId == 314 && routeStantions[i]._StantionId==315)|| (routeStantions[i - 1]._StantionId == 315 && routeStantions[i]._StantionId == 314))
                {
                    points.Add(new Point(0.532 * grid.ActualWidth, 0.502 * grid.ActualHeight));
                }
                else if ((routeStantions[i - 1]._StantionId == 118 && routeStantions[i]._StantionId == 119) || (routeStantions[i - 1]._StantionId == 119 && routeStantions[i]._StantionId == 118))
                {
                    points.Add(new Point(0.46 * grid.ActualWidth, 0.481 * grid.ActualHeight));
                }
                else if ((routeStantions[i - 1]._StantionId == 120 && routeStantions[i]._StantionId == 119) || (routeStantions[i - 1]._StantionId == 119 && routeStantions[i]._StantionId == 120))
                {
                    points.Add(new Point(0.502 * grid.ActualWidth, 0.418 * grid.ActualHeight));
                }
                else if ((routeStantions[i - 1]._StantionId == 315 && routeStantions[i]._StantionId == 316) || (routeStantions[i - 1]._StantionId == 316 && routeStantions[i]._StantionId == 315))
                {
                    points.Add(new Point(0.6155 * grid.ActualWidth, 0.502 * grid.ActualHeight));
                }
                else if ((routeStantions[i - 1]._StantionId == 122 && routeStantions[i]._StantionId == 123) || (routeStantions[i - 1]._StantionId == 123 && routeStantions[i]._StantionId == 122))
                {
                    points.Add(new Point(0.742 * grid.ActualWidth, 0.418 * grid.ActualHeight));
                }
                points.Add(new Point(routeStantions[i]._LeftProportion * grid.ActualWidth, routeStantions[i]._TopProportion * grid.ActualHeight));
            }

            polyLineSegment.Points = points;
            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = points.First();
            pathFigure.Segments.Add(polyLineSegment);
            pathFigure.IsClosed = false;
            PathGeometry myGeometry = new PathGeometry();
            myGeometry.Figures.Add(pathFigure);

            Path p = new Path() { Data = myGeometry, Stroke = Brushes.Aqua, StrokeThickness=2 };
            p.Name = "currentPath";
            BackgroundCanvas.Children.Add(p);

            var animation = new DoubleAnimationUsingPath
            {
                Duration = new Duration(new TimeSpan(0, 0, 3)),
                PathGeometry = PathGeometry.CreateFromGeometry(myGeometry),
                RepeatBehavior = RepeatBehavior.Forever
            };

            animation.Source = PathAnimationSource.X;
            circ.BeginAnimation(Canvas.LeftProperty, animation);
            animation.Source = PathAnimationSource.Y;
            circ.BeginAnimation(Canvas.TopProperty, animation);
        }

        private void BackgroundCanvas_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point tp = e.GetPosition(BackgroundCanvas);

            double leftProportion = tp.X / grid.ActualWidth;
            double topProportion = tp.Y / grid.ActualHeight;
          
            Stantion st = _MainMetropoliten.GetStantion(leftProportion, topProportion);
            if (st != null)
            {     
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    if (st==_FinishStation)
                    {
                        MessageBox.Show("You can't choose the same station for start end finish", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    _StartStation = st;
                    StartFlag.Margin = new Thickness(grid.ActualWidth * st._LeftProportion, grid.ActualHeight * st._TopProportion - StartFlag.ActualHeight,0,0);
                    CreateRoute(this, new RoutedEventArgs());
                }
                else if (e.RightButton==MouseButtonState.Pressed)
                {
                    if (st == _StartStation)
                    {
                        MessageBox.Show("You can't choose the same station for start end finish", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    _FinishStation = st;
                    FinishFlag.Margin= new Thickness(grid.ActualWidth * st._LeftProportion, grid.ActualHeight * st._TopProportion - FinishFlag.ActualHeight, 0, 0);
                    CreateRoute(this, new RoutedEventArgs());
                }
                MessageBox.Show(st._StantionName);
            }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            CreateRoute(this, new RoutedEventArgs());
            if (_StartStation!=null)
                StartFlag.Margin = new Thickness(grid.ActualWidth * _StartStation._LeftProportion, grid.ActualHeight * _StartStation._TopProportion - StartFlag.ActualHeight, 0, 0);
            if (_FinishStation!=null)
                FinishFlag.Margin = new Thickness(grid.ActualWidth * _FinishStation._LeftProportion, grid.ActualHeight * _FinishStation._TopProportion - FinishFlag.ActualHeight, 0, 0);

            circ.Height = grid.ActualHeight * 0.025;
            circ.Width = circ.Height;
            circ.RenderTransform = new TranslateTransform(-circ.Width / 2, -circ.Height / 2);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please, select start station by using left mouse button and finish station by using right mouse button", "Instruction", MessageBoxButton.OK, MessageBoxImage.Information);
            circ.Height = grid.ActualHeight * 0.025;
            circ.Width = circ.Height;
            circ.RenderTransform = new TranslateTransform(-circ.Width / 2, -circ.Height / 2);
        }
    }
}
