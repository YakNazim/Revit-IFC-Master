using Autodesk.Revit.UI;
using Revit.IFC.Common.Enums;
using Revit.IFC.Export.Exporter.PropertySet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***
 * Add this bit of code to the methods in case of ifc4 export 
***/
//if (ExporterCacheManager.ExportOptionsCache.ExportAs4)
//{
//    propertySetManufacturer.AddEntry(PropertySetEntry.CreateIdentifier("GlobalTradeItemNumber"));
//    propertySetManufacturer.AddEntry(PropertySetEntry.CreateEnumeratedValue("AssemblyPlace",
//    PropertyType.Label,
//    typeof(Toolkit.IFC4.PsetManufacturerTypeInformation_AssemblyPlace)));
//}

/// <summary>
/// This class defines a method - used as a delegate - to process custom PSets
/// </summary>

namespace Revit.IFC.Export.Exporter
{
    class CustomExporter
    {
        public static void InitCustomPropertySet(IList<IList<PropertySetDescription>> propertySets)
        {
            IList<PropertySetDescription> commonPropertySets = new List<PropertySetDescription>();

            // call the routines here
            //Init_Pset_Evac4BIM(commonPropertySets);
            Init_Pset_SpaceOccupancyRequirements(commonPropertySets);
            Init_Pset_SpaceOccupancyPrescriptionsReview(commonPropertySets);
            Init_Pset_SpaceFireSafetyRequirements(commonPropertySets);
            Init_Pset_SimulationID(commonPropertySets);
            Init_Pset_SpaceEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingCommon(commonPropertySets);
            Init_Pset_DoorCommon(commonPropertySets);
            Init_Pset_DoorEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingOccupancyRequirements(commonPropertySets);
            Init_Pset_BuildingOccupancyPrescriptionsReview(commonPropertySets);
            Init_Pset_SpaceCommon(commonPropertySets);
            Init_Pset_StairCommon(commonPropertySets);
            Init_Pset_StairPrescriptionsReview(commonPropertySets);
            Init_Pset_StairEgressPerformanceInformation(commonPropertySets);
            Init_Pset_BuildingStoreyCommon(commonPropertySets);
            Init_Pset_BuildingFireSafetyPrescriptionsReview(commonPropertySets);
            Init_Pset_BuildingStoreyOccupancyPrescriptionsReview(commonPropertySets);

            // Append the propertySets list
            propertySets.Add(commonPropertySets);

            TaskDialog.Show("Custon Revit Exporter", "Exporting using the Custom Revit Exporter");

        }

        public static void Init_Pset_SpaceOccupancyRequirements(IList<PropertySetDescription> commonPropertySets)
        {

           PropertySetEntry ifcPSE = null;

           PropertySetDescription propertySet = new PropertySetDescription();
           propertySet.Name = "Pset_SpaceOccupancyRequirements";
           propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);


            /*
            // These properties are handled by default in Revit Export 

            ifcPSE = new PropertySetEntry("OccupancyNumber");
            ifcPSE.PropertyName = "OccupancyNumber";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AreaPerOccupant");
            ifcPSE.PropertyName = "AreaPerOccupant";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyNumberPeak");
            ifcPSE.PropertyName = "AreaPerOccupant";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

             */

              


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);                
            }

        }


        public static void Init_Pset_SpaceOccupancyPrescriptionsReview(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceOccupancyPrescriptionsReview";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);


            /*
            // These properties are handled by default in Revit Export 

            ifcPSE = new PropertySetEntry("OccupancyNumber");
            ifcPSE.PropertyName = "OccupancyNumber";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AreaPerOccupant");
            ifcPSE.PropertyName = "AreaPerOccupant";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyNumberPeak");
            ifcPSE.PropertyName = "OccupancyNumberPeak";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

             */

            ifcPSE = new PropertySetEntry("OccupancyNumberSpace");
            ifcPSE.PropertyName = "OccupancyNumberSpace";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyNumberLimit");
            ifcPSE.PropertyName = "OccupancyNumberLimit";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AreaPerOccupantSpace");
            ifcPSE.PropertyName = "AreaPerOccupantSpace";
            ifcPSE.PropertyType = PropertyType.Area; // m²/occupant
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacity");
            ifcPSE.PropertyName = "EgressCapacity";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityRequirement");
            ifcPSE.PropertyName = "EgressCapacityRequirement";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("ExitCount");
            ifcPSE.PropertyName = "ExitCount";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("ExitCountRequirement");
            ifcPSE.PropertyName = "ExitCountRequirement";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressPathTravelDistance");
            ifcPSE.PropertyName = "EgressPathTravelDistance";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityAdequate");
            ifcPSE.PropertyName = "EgressCapacityAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("ExitCountAdequate");
            ifcPSE.PropertyName = "ExitCountAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityBalance");
            ifcPSE.PropertyName = "EgressCapacityBalance";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressPathTravelDistanceExcess");
            ifcPSE.PropertyName = "EgressPathTravelDistanceExcess";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyNumberExcess");
            ifcPSE.PropertyName = "OccupancyNumberExcess";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressComponentsPlacement");
            ifcPSE.PropertyName = "EgressComponentsPlacement";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);




            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_SpaceFireSafetyRequirements(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceFireSafetyRequirements";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);

            ifcPSE = new PropertySetEntry("AlarmTime");
            ifcPSE.PropertyName = "AlarmTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }
        }


        public static void Init_Pset_SimulationID(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SimulationID";
            propertySet.EntityTypes.Add(IFCEntityType.IfcProject);


            ifcPSE = new PropertySetEntry("EvacuationModelName");
            ifcPSE.PropertyName = "EvacuationModelName";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("EvacuationModelVersion");
            ifcPSE.PropertyName = "EvacuationModelVersion";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EvacuationModelVendor");
            ifcPSE.PropertyName = "EvacuationModelVendor";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EvacuationSimulationBrief");
            ifcPSE.PropertyName = "EvacuationSimulationBrief";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);





            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_SpaceEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);
                                   
 
            ifcPSE = new PropertySetEntry("EvacuationTime");
            ifcPSE.PropertyName = "EvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("InitialOccupancyNumber");
            ifcPSE.PropertyName = "InitialOccupancyNumber";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyHistory");
            ifcPSE.PropertyName = "OccupancyHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);                
            }

        }

        public static void Init_Pset_BuildingEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);
              

            ifcPSE = new PropertySetEntry("MinTravelDistance");
            ifcPSE.PropertyName = "MinTravelDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("MaxTravelDistance");
            ifcPSE.PropertyName = "MaxTravelDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AverageTravelDistance");
            ifcPSE.PropertyName = "AverageTravelDistance";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EvacuationTimeOverall");
            ifcPSE.PropertyName = "EvacuationTimeOverall";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AverageEvacuationTime");
            ifcPSE.PropertyName = "AverageEvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("MinEvacuationTime");
            ifcPSE.PropertyName = "MinEvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("OccupancyHistoryOverall");
            ifcPSE.PropertyName = "OccupancyHistoryOverall";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }



        public static void Init_Pset_BuildingCommon(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);


            ifcPSE = new PropertySetEntry("OccupancyDistributionDayNight");
            ifcPSE.PropertyName = "OccupancyDistributionDayNight";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            // Built-in Revit
            ifcPSE = new PropertySetEntry("OccupancyType");
            ifcPSE.PropertyName = "OccupancyType";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);
           
            ifcPSE = new PropertySetEntry("SprinklerProtection");
            ifcPSE.PropertyName = "SprinklerProtection";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EmergencyCommunication");
            ifcPSE.PropertyName = "EmergencyCommunication";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }


        public static void Init_Pset_DoorCommon(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_DoorCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcDoor);


            ifcPSE = new PropertySetEntry("isAccessible");
            ifcPSE.PropertyName = "isAccessible";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("RequiredDoorFlowrate");
            ifcPSE.PropertyName = "RequiredDoorFlowrate";
            ifcPSE.PropertyType = PropertyType.Real;
            propertySet.AddEntry(ifcPSE);

            // Builtin
            /*ifcPSE = new PropertySetEntry("FireExit");
            ifcPSE.PropertyName = "FireExit";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);*/

            ifcPSE = new PropertySetEntry("DischargeExit");
            ifcPSE.PropertyName = "DischargeExit";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("DimensionAdequate");
            ifcPSE.PropertyName = "DimensionAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_BuildingStoreyCommon(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingStoreyCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuildingStorey);

            // Built in
            /*ifcPSE = new PropertySetEntry("EntranceLevel");
            ifcPSE.PropertyName = "EntranceLevel";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);*/

            


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_BuildingStoreyOccupancyPrescriptionsReview(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingStoreyOccupancyPrescriptionsReview";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuildingStorey);

       

            ifcPSE = new PropertySetEntry("OccupancyNumberStorey");
            ifcPSE.PropertyName = "OccupancyNumberStorey";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityStorey");
            ifcPSE.PropertyName = "EgressCapacityStorey";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityRequirementStorey");
            ifcPSE.PropertyName = "EgressCapacityRequirementStorey";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("ExitCountStorey");
            ifcPSE.PropertyName = "ExitCountStorey";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("ExitCountRequirementStorey");
            ifcPSE.PropertyName = "ExitCountRequirementStorey";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityAdequateStorey");
            ifcPSE.PropertyName = "EgressCapacityAdequateStorey";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("ExitCountAdequateStorey");
            ifcPSE.PropertyName = "ExitCountAdequateStorey";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityBalanceStorey");
            ifcPSE.PropertyName = "EgressCapacityBalanceStorey";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCount");
            ifcPSE.PropertyName = "StairCount";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCapacity");
            ifcPSE.PropertyName = "StairCapacity";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCountRequirement");
            ifcPSE.PropertyName = "StairCountRequirement";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCapacityRequirement");
            ifcPSE.PropertyName = "StairCapacityRequirement";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCountAdequate");
            ifcPSE.PropertyName = "StairCountAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCapacityAdequate");
            ifcPSE.PropertyName = "StairCapacityAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCapacityBalance");
            ifcPSE.PropertyName = "StairCapacityBalance";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            



            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_DoorEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {
            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_DoorEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcDoor);


            ifcPSE = new PropertySetEntry("FirstOccupantInTime");
            ifcPSE.PropertyName = "FirstOccupantInTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("LastOccupantOutTime");
            ifcPSE.PropertyName = "LastOccupantOutTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("AverageOccupantFlowrate");
            ifcPSE.PropertyName = "AverageOccupantFlowrate";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            ifcPSE = new PropertySetEntry("TotalUse");
            ifcPSE.PropertyName = "TotalUse";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("DoorFlowrateHistory");
            ifcPSE.PropertyName = "DoorFlowrateHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);
            

            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }


        }

        public static void Init_Pset_BuildingOccupancyRequirements(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingOccupancyRequirements";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);

            ifcPSE = new PropertySetEntry("PreEvacuationTime");
            ifcPSE.PropertyName = "PreEvacuationTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            // Occupant profiles 
            ifcPSE = new PropertySetEntry("OccupantProfilesList");
            ifcPSE.PropertyName = "OccupantProfilesList";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

             

            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }
        }


        public static void Init_Pset_BuildingOccupancyPrescriptionsReview(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingOccupancyPrescriptionsReview";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);

            



            ifcPSE = new PropertySetEntry("OccupancyNumberBuilding");
            ifcPSE.PropertyName = "OccupancyNumberBuilding";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCountContinuity");
            ifcPSE.PropertyName = "StairCountContinuity";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCapacityContinuity");
            ifcPSE.PropertyName = "StairCapacityContinuity";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("StairCapacityPerOccupant");
            ifcPSE.PropertyName = "StairCapacityPerOccupant";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressCapacityPerOccupant");
            ifcPSE.PropertyName = "EgressCapacityPerOccupant";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyNumberLimitSingleExitSpace");
            ifcPSE.PropertyName = "OccupancyNumberLimitSingleExitSpace";
            ifcPSE.PropertyType = PropertyType.Count;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressPathTravelDistanceLimitLowOccupancy");
            ifcPSE.PropertyName = "EgressPathTravelDistanceLimitLowOccupancy";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressPathTravelDistanceLimitHighOccupancy");
            ifcPSE.PropertyName = "EgressPathTravelDistanceLimitHighOccupancy";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("EgressPathTravelDistanceLimit");
            ifcPSE.PropertyName = "EgressPathTravelDistanceLimit";
            ifcPSE.PropertyType = PropertyType.Length;
            propertySet.AddEntry(ifcPSE);




            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }
        }



        public static void Init_Pset_SpaceCommon(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_SpaceCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcSpace);

                         

            ifcPSE = new PropertySetEntry("AdmittedProfiles");
            ifcPSE.PropertyName = "AdmittedProfiles";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            // Already included by default in Revit
            /*
            ifcPSE = new PropertySetEntry("Category");
            ifcPSE.PropertyName = "Category";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);*/



            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_StairPrescriptionsReview(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_StairPrescriptionsReview";
            propertySet.EntityTypes.Add(IFCEntityType.IfcStair);


             

            ifcPSE = new PropertySetEntry("RiserHeightAdequate");
            ifcPSE.PropertyName = "RiserHeightAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("TreadLengthAdequate");
            ifcPSE.PropertyName = "TreadLengthAdequate";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("FireEgressStair");
            ifcPSE.PropertyName = "FireEgressStair";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }
        public static void Init_Pset_StairCommon(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_StairCommon";
            propertySet.EntityTypes.Add(IFCEntityType.IfcStair);


            ifcPSE = new PropertySetEntry("AdmittedProfiles");
            ifcPSE.PropertyName = "AdmittedProfiles";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }

        public static void Init_Pset_StairEgressPerformanceInformation(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_StairEgressPerformanceInformation";
            propertySet.EntityTypes.Add(IFCEntityType.IfcStair);



            ifcPSE = new PropertySetEntry("FirstOccupantInTime");
            ifcPSE.PropertyName = "FirstOccupantInTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("LastOccupantOutTime");
            ifcPSE.PropertyName = "LastOccupantOutTime";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("AverageOccupantFlowrate");
            ifcPSE.PropertyName = "AverageOccupantFlowrate";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("OccupancyHistory");
            ifcPSE.PropertyName = "OccupancyHistory";
            ifcPSE.PropertyType = PropertyType.Text;
            propertySet.AddEntry(ifcPSE);


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }


        public static void Init_Pset_BuildingFireSafetyPrescriptionsReview(IList<PropertySetDescription> commonPropertySets)
        {

            PropertySetEntry ifcPSE = null;

            PropertySetDescription propertySet = new PropertySetDescription();
            propertySet.Name = "Pset_BuildingFireSafetyPrescriptionsReview";
            propertySet.EntityTypes.Add(IFCEntityType.IfcBuilding);


            ifcPSE = new PropertySetEntry("SprinklerProtectionRequirement");
            ifcPSE.PropertyName = "SprinklerProtectionRequirement";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            ifcPSE = new PropertySetEntry("SprinklerProtectionLacking");
            ifcPSE.PropertyName = "SprinklerProtectionLacking";
            ifcPSE.PropertyType = PropertyType.Boolean;
            propertySet.AddEntry(ifcPSE);

            

            


            if (ifcPSE != null)
            {
                commonPropertySets.Add(propertySet);
            }

        }




    }
}
