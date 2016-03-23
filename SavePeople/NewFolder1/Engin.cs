using System;
using System.Collections.Generic;
using System.Windows.Controls;

public class Engine
{

    private Overmind Overmind;
    private Unit Larve;
    private Unit Drone;
    private Unit Overlord;
    private Unit Zergling;
    private Unit Queen;
    private Unit Roaches;
    private Unit Benelings;
    private Unit Hydralisk;
    private Unit Infestor;
    private Unit Mutalisk;
    private Unit NydusWarm;
    private Unit SwarmHost;
    private Unit Overseer;
    private Unit Coruptor;
    private Unit Ultralisk;
    private Unit Viper;
    private Unit BroodLord;
    private Resource Nutritient;
    private Resource Energy;
    private Resource Creep;
    private Resource Supply;
    private Structure Hatchery;
    private Structure SpawningPool;
    private Structure Extractor;
    private Structure EvolutionChamber;
    private Structure RoachWarren;
    private Structure BenelingNest;
    private Structure SpineCrawler;
    private Structure SporeCrawler;
    private Structure Lair;
    private Structure HydraliskDen;
    private Structure NydusNetwork;
    private Structure InfestationPit;
    private Structure Spire;
    private Structure Hive;
    private Structure UltraliskCavern;
    private Structure GreatSpire;

    public Engine()
    { 

        List<ItList> myList = new List<ItList>
        {
            new ItList(1,"Overmind"),
            new ItList(2,"Larve"),
            new ItList(3,"Drone"),
            new ItList(4,"Overlord"),
            new ItList(5,"Zergling"),
            new ItList(6,"Queen"),
            new ItList(7,"Roach"),
            new ItList(8,"Beneling"),
            new ItList(9,"Hydralisk"),
            new ItList(10,"Infestor"),
            new ItList(11,"Mutalisk"),
            new ItList(12,"Nydus Worm"),
            new ItList(13,"Swarm host"),
            new ItList(14,"Overseer"),
            new ItList(15,"Coruptor"),
            new ItList(16,"Ultralisk"),
            new ItList(17,"Viper"),
            new ItList(18,"Brood lord"),
            new ItList(20,"Nutritient"),
            new ItList(21,"Energy"),
            new ItList(22,"Creep"),
            new ItList(23,"Supply"),
            new ItList(30,"Hatchery"),
            new ItList(31,"Spawning Pool"),
            new ItList(32,"Extractor"),
            new ItList(33,"Evolution Chamber"),
            new ItList(34,"Roach Warren"),
            new ItList(35,"Beneling nest"),
            new ItList(36,"Spine crawler"),
            new ItList(37,"Spore crawler"),
            new ItList(38,"Lair"),
            new ItList(39,"Hydralisk den"),
            new ItList(40,"Nydus network"),
            new ItList(41,"Investation pit"),
            new ItList(42,"Spire"),
            new ItList(43,"Hive"),
            new ItList(44,"Ultralisk cavern"),
            new ItList(45,"Great spire")
        };

        Overmind = new Overmind(70, 100);
        Larve = new Unit("Larve",2,0,1,0,1);
        Drone = new Unit("Drone",3,0,1,50,3);
        Overlord = new Unit("Overlord",4,0,Int64.MaxValue,150,10);
        Zergling = new Unit("Zergling", 5, 0, 0, 60, 4);
        Queen = new Unit("Queen", 6, 0, 0, 200, 6);
        Roaches = new Unit("Roach", 7, 0, 0, 150, 5);
        Benelings = new Unit("Beneling", 8, 0, 0, 100, 6);
        Hydralisk = new Unit("Hydralisk", 9, 0, 0, 200, 5);
        Infestor = new Unit("Infestor", 10, 0, 0, 350, 10);
        Mutalisk = new Unit("Mutalisk", 11, 0, 0, 400, 10);
        NydusWarm = new Unit("Nydus warm", 12, 0, 0, 500, 20);
        SwarmHost = new Unit("Swarm host", 13, 0, 0, 650, 15);
        Overseer = new Unit("Overseer", 14, 0, 0, 600, 8);
        Coruptor = new Unit("Coruptor", 15, 0, 0, 800, 12);
        Ultralisk = new Unit("Ultralist", 16, 0, 0, 1000, 20);
        Viper = new Unit("Viper", 17, 0, 0, 1600, 25);
        BroodLord = new Unit("Broor lord", 18, 0, 0, 2000, 25);
        Nutritient = new Resource("Nutritient",0,0,0);
        Energy = new Resource("Energy",70,100,10);
        Creep = new Resource("Creep",0,Int64.MaxValue,0);
        Supply = new Resource("Supply", 3, 3, 0);
        Hatchery = new Structure("Hatchery",50,0,Int64.MaxValue);
        SpawningPool = new Structure("Spawning pool", 31, 0, Int64.MaxValue);
        Extractor = new Structure("Extractor", 32, 0, Int64.MaxValue);
        EvolutionChamber = new Structure("Evolution chamber", 33, 0, Int64.MaxValue);
        RoachWarren = new Structure("Roach warren", 34, 0, Int64.MaxValue);
        BenelingNest = new Structure("Beneling nest", 35, 0, Int64.MaxValue);
        SpineCrawler = new Structure("Spine crawler", 36, 0, Int64.MaxValue);
        SporeCrawler = new Structure("Spore crawler", 37, 0, Int64.MaxValue);
        Lair = new Structure("Lair", 38, 0, Int64.MaxValue);
        HydraliskDen = new Structure("Hydralisk den", 39, 0, Int64.MaxValue);
        NydusNetwork = new Structure("Nydus network", 40, 0, Int64.MaxValue);
        InfestationPit = new Structure("Infestation pit", 41, 0, Int64.MaxValue);
        Spire = new Structure("Spire", 42, 0, Int64.MaxValue);
        Hive = new Structure("Hive", 43, 0, Int64.MaxValue);
        UltraliskCavern = new Structure("Ultralisk cavern", 44, 0, Int64.MaxValue);
        GreatSpire = new Structure("Great spire", 45, 0, Int64.MaxValue);

}

    public Int64[] getObjPar()
    {
        Int64 SuppyEngNum = (Drone.GetNumber() + Zergling.GetNumber() + Queen.GetNumber() * 2 + Roaches.GetNumber() * 2 + Benelings.GetNumber() + Hydralisk.GetNumber() * 3 +
            Infestor.GetNumber() * 4 + Mutalisk.GetNumber() * 4 + NydusWarm.GetNumber() * 4 + SwarmHost.GetNumber() * 5 + Coruptor.GetNumber() * 6 + Ultralisk.GetNumber() * 8 +
            Viper.GetNumber() * 9 + BroodLord.GetNumber() * 10);
        Int64 SupplyMaxNum = ((Overlord.GetNumber() * 6) + (Overseer.GetNumber() * 8) + (Hatchery.GetValue() * 5) + 3);
        Int64 UnitNum = (Drone.GetNumber() + Zergling.GetNumber() + Queen.GetNumber() + Roaches.GetNumber() + Benelings.GetNumber() + Hydralisk.GetNumber() + Infestor.GetNumber() +
            Mutalisk.GetNumber() + NydusWarm.GetNumber() + SwarmHost.GetNumber() + Coruptor.GetNumber() + Ultralisk.GetNumber() + Viper.GetNumber() + BroodLord.GetNumber());
        Int64[] num = new Int64[]
        {
            Energy.GetValue(),                      //labStatEn
            Nutritient.GetValue(),                  //labStatMeat
            Hatchery.GetValue(),                    //labStatHat
            Larve.GetNumber(),                      //labStatLarv
            Hatchery.GetValue()*3,                  //labStatLarvMax
            SuppyEngNum,                            //labStatSupplyEng
            SupplyMaxNum,                           //labStatSupplyMax
            UnitNum,                                //labStatUnits

            Hatchery.GetValue(),                    //labStrucHat
            Energy.GetValue()-Overmind.GetEnegry(), //labStrucEn
            SpawningPool.GetValue(),                //labStrucSpPool
            Extractor.GetValue(),                   //labStrucExtr
            EvolutionChamber.GetValue(),            //labStrucEvChamber
            RoachWarren.GetValue(),                 //labStrucRoachWarren
            BenelingNest.GetValue(),                //labStrucBenNest
            SpineCrawler.GetValue(),                //labStrucSpineCr
            SporeCrawler.GetValue(),                //labStrucSporeCr
            Lair.GetValue(),                        //labStrucLair
            HydraliskDen.GetValue(),                //labStrucHydraDen
            NydusNetwork.GetValue(),                //labStrucNydNet
            InfestationPit.GetValue(),              //labStrucInfesPit
            Spire.GetValue(),                       //labStrucSpire
            Hive.GetValue(),                        //labStrucHive
            UltraliskCavern.GetValue(),             //labStrucUltCav
            GreatSpire.GetValue(),                  //labStrucGrSpire

            Overmind.GetEnegry(),                   //labResOvEn
            Overmind.GetEnegry()*0+3,               //labResOvEnGain
            Energy.GetValue(),                      //labResEnAll
            Nutritient.GetValue(),                  //labResMeat
            Creep.GetValue(),                       //labResCreep
            0,                                      //labResCrNut
            0,                                      //labResCrEn
            SuppyEngNum,                            //labResSupplyEng
            SupplyMaxNum,                           //labResSupplyMax

            1,                                      //labUnitOv
            Larve.GetNumber(),                      //labUnitLarv
            Drone.GetNumber(),                      //labUnitDrones
            Overlord.GetNumber(),                   //labUnitOverlord
            Zergling.GetNumber(),                   //labUnitZergling
            Queen.GetNumber(),                      //labUnitQueen
            Roaches.GetNumber(),                    //labUnitRoach
            Benelings.GetNumber(),                  //labUnitBeneling
            Hydralisk.GetNumber(),                  //labUnitHydra
            Infestor.GetNumber(),                   //labUnitInfes
            Mutalisk.GetNumber(),                   //labUnitMutalisk
            NydusWarm.GetNumber(),                  //labUnitNydWorm 
            SwarmHost.GetNumber(),                  //labUnitSwarmHost
            Overseer.GetNumber(),                   //labUnitOverseer
            Coruptor.GetNumber(),                   //labUnitCoruptor
            Ultralisk.GetNumber(),                  //labUnitUltralisk
            Viper.GetNumber(),                      //labUnitViper
            BroodLord.GetNumber()                   //labUnitBrLord

        };
        return num;
    }

    public void tickchange()
    {
        Overmind.WaitAClice();

    }
}
