using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SavePeople
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        private Engine engine;
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private List<StackPanel> SPList = new List<StackPanel> { };
        private List<Boolean> MyFlagList = new List<bool> { };
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Velcome, Overmind. The Swarm feels your presence! " +
    "As an overmind you should have some unique skills. They will help you establish a new start for your swarm. "+
    "Remember, you needs swarm as much as swarm needs you! Now, first you should know, that as an overmind you have little psjonic energy. "+
    "You should be able to use your psjonic energy to spawn down a larve. Then you ought to be able to hatch a drone from it " +
    "and mutate it into a hatchery. Do it, and I'll present you new information.", "Welcome!");
           
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            
            engine = new Engine();
            ConectObjComp(engine);
            dispatcherTimer.Start();
            AddToListPanel();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            engine.tickchange();
            ConectObjComp(engine);
           // throw new NotImplementedException();
        }

        public void ConectObjComp(Engine engine)
        {
            Int64[] Num = engine.getObjPar();
            numStatEn.Content = Num[0].ToString();
            numStatsMeat.Content = Num[1].ToString();
            numStatsHat.Content = Num[2].ToString();
            numStatLarv.Content = Num[3].ToString();
            numStatLarvMax.Content = Num[4].ToString();
            numStatSupplEng.Content = Num[5].ToString();
            numStatSupplyMax.Content = Num[6].ToString();
            numStatUnits.Content = Num[7].ToString();

            numStrucHat.Content = Num[8].ToString();
            numStrucEn.Content = Num[9].ToString();
            numStrucSpPool.Content = Num[10].ToString();
            numStrucExtr.Content = Num[11].ToString();
            numStrucEvChamber.Content = Num[12].ToString();
            numStrucRoachWarren.Content = Num[13].ToString();
            numStrucBenNest.Content = Num[14].ToString();
            numStrucSpineCr.Content = Num[15].ToString();
            numStrucSporeCr.Content = Num[16].ToString();
            numStrucLair.Content = Num[17].ToString();
            numStrucHydDen.Content = Num[18].ToString();
            numStrucNydNet.Content = Num[19].ToString();
            numStrucInfecPit.Content = Num[20].ToString();
            numStrucSpire.Content = Num[21].ToString();
            numStrucHive.Content = Num[22].ToString();
            numStrucUltCav.Content = Num[23].ToString();
            numStrucGrSpire.Content = Num[24].ToString();
            
            numResOvEn.Content = Num[25].ToString();
            numResOvEnGain.Content = Num[26].ToString();
            numResAllEn.Content = Num[27].ToString();
            numResMeat.Content = Num[28].ToString();
            numResCreep.Content = Num[29].ToString();
            numResCrMeat.Content = Num[30].ToString();
            numResCrEn.Content = Num[31].ToString();
            numResSupplyEng.Content = Num[32].ToString();
            numResSupplyMax.Content = Num[33].ToString();
           
            numUnitOv.Content = Num[34].ToString();
            numUnitLarv.Content = Num[35].ToString();
            numUnitDrones.Content = Num[36].ToString();
            numUnitOverlord.Content = Num[37].ToString();
            numUnitZergling.Content = Num[38].ToString();
            numUnitQueen.Content = Num[39].ToString();
            numUnitRoach.Content = Num[40].ToString();
            numUnitBeneling.Content = Num[41].ToString();
            numUnitHydra.Content = Num[42].ToString();
            numUnitInfes.Content = Num[43].ToString();
            numUnitMutalisk.Content = Num[44].ToString();
            numUnitNydWorm.Content = Num[45].ToString();
            numUnitSwarmHost.Content = Num[46].ToString();
            numUnitOverseer.Content = Num[47].ToString();
            numUnitCoruptor.Content = Num[48].ToString();
            numUnitUltralisk.Content = Num[49].ToString();
            numUnitViper.Content = Num[50].ToString();
            numUnitBrLord.Content = Num[51].ToString();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            ConectObjComp(engine);
        }

        private void labUnitOv_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PanelVisibleLabClick();
            OvPanel.Visibility=Visibility.Visible;
        }   //StackPanel OvPanel (overmind) visible

        private void PanelVisibleLabClick()
        {
            foreach (var item in SPList)
            {
                item.Visibility = Visibility.Hidden;
            }
        }             //make every panel invisible
        private void AddToListPanel()
        {
            SPList.Add(OvPanel);
            SPList.Add(LarvPanel);
            SPList.Add(DronPanel);
            SPList.Add(OvLdPanel);
            SPList.Add(ZergPanel);
            SPList.Add(QueenPanel);
            SPList.Add(RoachPanel);
            SPList.Add(BenPanel);
            SPList.Add(HydPanel);
            SPList.Add(InfPanel);
            SPList.Add(MutPanel);
            SPList.Add(NydWPanel);
            SPList.Add(SwHPanel);
            SPList.Add(OvSPanel);
            SPList.Add(CorPanel);
            SPList.Add(UltPanel);
            SPList.Add(VipPanel);
            SPList.Add(BrLoPanel);
        }                   //add panels to List<StackPanel> SPList
    }

}
