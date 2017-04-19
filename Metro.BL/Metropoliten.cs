using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.BL
{
    public class Metropoliten
    {
        public List<Stantion> _Stantions;
        public delegate Stantion NextStepDelegate(Stantion temp);

        public Metropoliten()
        {
            _Stantions = new List<Stantion>();
            _Stantions.Add(new Stantion(110, "Akademmistechko", Branch.Red, null, 0.0214, 0.483));
            _Stantions.Add(new Stantion(111, "Zhytomyrska", Branch.Red, null, 0.0767, 0.483));
            _Stantions.Add(new Stantion(112, "Sviatosyn", Branch.Red, null, 0.12, 0.483));
            _Stantions.Add(new Stantion(113, "Nyvky", Branch.Red, null, 0.178, 0.483));
            _Stantions.Add(new Stantion(114, "Beresteiska", Branch.Red, null, 0.234, 0.483));
            _Stantions.Add(new Stantion(115, "Shulavska", Branch.Red, null, 0.2755, 0.483));
            _Stantions.Add(new Stantion(116, "Politekhnichnyi Instytut", Branch.Red, null, 0.339, 0.483));
            _Stantions.Add(new Stantion(117, "Vokzalna", Branch.Red, null, 0.392, 0.483));
            _Stantions.Add(new Stantion(118, "Universytet", Branch.Red, null, 0.437, 0.483));
            _Stantions.Add(new Stantion(119, "Teatralna", Branch.Red, null, 0.4888, 0.435));
            _Stantions.Add(new Stantion(120, "Khreshchatyk", Branch.Red, null, 0.567, 0.417));
            _Stantions.Add(new Stantion(121, "Arsenalna", Branch.Red, null, 0.631, 0.417));
            _Stantions.Add(new Stantion(122, "Dnipro", Branch.Red, null, 0.705, 0.417));
            _Stantions.Add(new Stantion(123, "Hidropark", Branch.Red, null, 0.767, 0.399));
            _Stantions.Add(new Stantion(124, "Livoberezhna", Branch.Red, null, 0.815, 0.359));
            _Stantions.Add(new Stantion(125, "Darnytsia", Branch.Red, null, 0.862, 0.3177));
            _Stantions.Add(new Stantion(126, "Chernihivska", Branch.Red, null, 0.903, 0.284));
            _Stantions.Add(new Stantion(127, "Lisova", Branch.Red, null, 0.944, 0.253));

            _Stantions.Add(new Stantion(210, "Heroiv Dnipra", Branch.Blue, null, 0.5679, 0.0514));
            _Stantions.Add(new Stantion(211, "Minska", Branch.Blue, null, 0.5679, 0.099));
            _Stantions.Add(new Stantion(212, "Obolon", Branch.Blue, null, 0.5679, 0.14));
            _Stantions.Add(new Stantion(213, "Petrivka", Branch.Blue, null, 0.5679, 0.195));
            _Stantions.Add(new Stantion(214, "Tarasa Shevchenka", Branch.Blue, null, 0.5679, 0.2448));
            _Stantions.Add(new Stantion(215, "Kontraktova Ploshcha", Branch.Blue, null, 0.5679, 0.291));
            _Stantions.Add(new Stantion(216, "Poshtova Ploshcha", Branch.Blue, null, 0.5679, 0.339));
            _Stantions.Add(new Stantion(217, "Maidan Nezalezhnosti", Branch.Blue, null, 0.5679, 0.3844));
            _Stantions.Add(new Stantion(218, "Ploshcha Lva Tolstoho", Branch.Blue, null, 0.5679, 0.504));
            _Stantions.Add(new Stantion(219, "Olimpiiska", Branch.Blue, null, 0.5679, 0.571));
            _Stantions.Add(new Stantion(220, "Palac \"Ukraina\"", Branch.Blue, null, 0.5679, 0.639));
            _Stantions.Add(new Stantion(221, "Lybidska", Branch.Blue, null, 0.5679, 0.704));
            _Stantions.Add(new Stantion(222, "Demiivska", Branch.Blue, null, 0.5679, 0.781));
            _Stantions.Add(new Stantion(223, "Holosiivska", Branch.Blue, null, 0.5188, 0.819));
            _Stantions.Add(new Stantion(224, "Vasylkivska", Branch.Blue, null, 0.4297, 0.819));
            _Stantions.Add(new Stantion(225, "Vystavkovyi Centr", Branch.Blue, null, 0.359, 0.819));
            _Stantions.Add(new Stantion(226, "Ipodrom", Branch.Blue, null, 0.297, 0.819));
            _Stantions.Add(new Stantion(227, "Teremky", Branch.Blue, null, 0.23, 0.819));

            _Stantions.Add(new Stantion(310, "Syrets", Branch.Green, null, 0.358, 0.213));
            _Stantions.Add(new Stantion(311, "Dorohozhychi", Branch.Green, null, 0.39, 0.2709));
            _Stantions.Add(new Stantion(312, "Lukianivska", Branch.Green, null, 0.427, 0.333));
            _Stantions.Add(new Stantion(314, "Zoloti Vorota", Branch.Green, null, 0.475, 0.409));
            _Stantions.Add(new Stantion(315, "Palats Sportu", Branch.Green, null, 0.6, 0.503));
            _Stantions.Add(new Stantion(316, "Klovska", Branch.Green, null, 0.63, 0.5188));
            _Stantions.Add(new Stantion(317, "Pecherska", Branch.Green, null, 0.649, 0.55));
            _Stantions.Add(new Stantion(318, "Druzhby Narodiv", Branch.Green, null, 0.666, 0.5778));
            _Stantions.Add(new Stantion(319, "Vysubychi", Branch.Green, null, 0.686, 0.603));
            _Stantions.Add(new Stantion(321, "Slavutych", Branch.Green, null, 0.7567, 0.707));
            _Stantions.Add(new Stantion(322, "Osokorky", Branch.Green, null, 0.783, 0.745));
            _Stantions.Add(new Stantion(323, "Pozniaky", Branch.Green, null, 0.809, 0.78));
            _Stantions.Add(new Stantion(324, "Kharkivska", Branch.Green, null, 0.832, 0.817));
            _Stantions.Add(new Stantion(325, "Vyrlytsia", Branch.Green, null, 0.862, 0.859));
            _Stantions.Add(new Stantion(326, "Boryspilska", Branch.Green, null, 0.8925, 0.904));
            _Stantions.Add(new Stantion(327, "Chervonyi Khutir", Branch.Green, null, 0.923, 0.946));

            _Stantions.Find(o => o._StantionId == 119)._TransferToStantion = _Stantions.Find(o => o._StantionId == 314);
            _Stantions.Find(o => o._StantionId == 314)._TransferToStantion = _Stantions.Find(o => o._StantionId == 119);

            _Stantions.Find(o => o._StantionId == 120)._TransferToStantion = _Stantions.Find(o => o._StantionId == 217);
            _Stantions.Find(o => o._StantionId == 217)._TransferToStantion = _Stantions.Find(o => o._StantionId == 120);

            _Stantions.Find(o => o._StantionId == 218)._TransferToStantion = _Stantions.Find(o => o._StantionId == 315);
            _Stantions.Find(o => o._StantionId == 315)._TransferToStantion = _Stantions.Find(o => o._StantionId == 218);


            for (int i = 1; i < _Stantions.Count - 1; i++)
            {
                _Stantions[i].Next = _Stantions[i + 1];
                _Stantions[i].Previous = _Stantions[i - 1];
            }

            _Stantions[0].Next = _Stantions[1];
            _Stantions[0].Previous = null;
            _Stantions[_Stantions.Count - 1].Next = null;
            _Stantions[_Stantions.Count - 1].Previous = _Stantions[_Stantions.Count - 2];
        }

        public List<Stantion> GetRoute(int StartStantionId, int FinishStantionId)
        {
            List<Stantion> result = new List<Stantion>();
            Stantion Start = _Stantions.Find(o => o._StantionId == StartStantionId);
            result.Add(Start);
            Stantion Finish = _Stantions.Find(o => o._StantionId == FinishStantionId);

            if (Start._Branch == Finish._Branch)
                GoForward(result, Start, Finish);
            else
                GoWithTransfer(result, Start, Finish);
            return result;
        }

        public void GoForward(List<Stantion> result, Stantion start, Stantion end)
        {
            Stantion temp = start;
            NextStepDelegate NextStep = null;
            if (start._StantionId > end._StantionId)
                NextStep = GoPreviousStep; 
            else if (start._StantionId < end._StantionId)
                NextStep = GoNextStep;
            if (NextStep != null)
            {
                temp = NextStep(temp);
                while (temp != end)
                {
                    result.Add(temp);
                    temp = NextStep(temp);
                }
                result.Add(temp);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public void GoWithTransfer(List<Stantion> result, Stantion start, Stantion end)
        {
            Stantion Current = start;
            NextStepDelegate NextStep = null;

            if (start._StantionId > (int)start._Branch)
                NextStep = GoPreviousStep;

            else if (start._StantionId < (int)start._Branch + 1)
                NextStep = GoNextStep;

            if (NextStep != null)
            {
                while (Current._TransferToStantion == null)
                {
                    Current = NextStep(Current);
                    result.Add(Current);
                }
                if (Current._TransferToStantion._Branch == end._Branch)
                    Current = Current._TransferToStantion;
                else
                {
                    Current = NextStep(Current);
                    result.Add(Current);
                    if (Current._TransferToStantion._Branch == end._Branch)
                        Current = Current._TransferToStantion;
                }
                result.Add(Current);
                GoForward(result, Current, end);
            }
            else
                throw new NotImplementedException();
        }

        public Stantion GetStantion(double leftProportion, double topProportion)
        {
            foreach(var stantion in _Stantions)
            {
                if ((leftProportion > stantion._LeftProportion - 0.01227 && leftProportion < stantion._LeftProportion + 0.01227) && (topProportion > stantion._TopProportion - 0.01227 && topProportion < stantion._TopProportion + 0.01227))
                    return stantion;
            }
            return null;
        }


        private Stantion GoNextStep(Stantion temp) => temp.Next;

        private Stantion GoPreviousStep(Stantion temp) => temp.Previous;
    }
}
