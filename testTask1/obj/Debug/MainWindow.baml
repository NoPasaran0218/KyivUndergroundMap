   M S B A M L   `   `   `  ����D  @testTask1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:testTask1	testTask1  5   	       testTask1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:testTask1     5   	   -   5          �Name$  _Window��5   �    � Title$ Map for Kyiv Underground��6	   $	��623��6*   $	��600��67   $	��523��6C   $	��500��6S    � 	Resources 5	      ��%    5
      .��5      � -   5         �Name$
 grid��5      $	��500��6   $	��500��6(   
������.+�5   
   �� -   5         ��Name$ mainBg��5      $"��/Resources/MapBackground.png��6    $
��Fill=�6F   $��Center=�6U   $��Center=�6r   6�   �� 5   
   -   5        $ 	StartFlag��5   t   $��/Resources/startFlag.png��6   $
��None=�62   $	��Top=�6A   $
��Left=�6Y   $��-50 -50 0 0q�6�   6�   �� 5   
   -   5        $ 
FinishFlag��5   u   $��/Resources/finishFlag.png��6   $
��None=�63   $	��Top=�6B   $
��Left=�6Z   $��-50 -50 0 0q�6�   6�   �� 5   
   $��20��6   $
��auto��6    $<��6Please, Use Left Mouse Button For Choose Start Station��6-   $��12(�6k   $��Normal$�6y   $	��Top=�6�   $��5 10 0 0q�6�   6�   �� 5   
   $��20��6   $
��auto��6    $5��/And Left Mouse Button For Choose Finish Station��6-   $��12(�6d   $��Normal$�6r   $	��Top=�6�   $��5 30 0 0q�6�   6�   �� 5   
   -   5         ��Name$ BackgroundCanvas��5      
������ .+�5      A� -   5         A�Name$
 circ��5      $��13��5      $��13��5      ��5      
� 5       
� RadiusX$ 1Q�6*    
� RadiusY$ 1Q�66   	 
� GradientOrigin$	 0.3, 0.3&�6B   .��5      � 
 � Color$
 Yellow��6'    � Offset$ 0Q�66   � 5      $
 Black��6'   $ 1Q�65   5      z�5      T� 5       T� X$ -2Q�6)    T� Y$ -7Q�60   5!      5"      5#      5$      