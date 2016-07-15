/*------------------------------------------------------------------------------
gbXML version 6.01 - Maintained by gbXML.org
 
C# Object equivalent to gbXML XSD version 6.01

Created 7/14/2016
------------------------------------------------------------------------------*/

using System.Xml.Serialization;

namespace gbXML_601
{
   
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum absorptanceUnitEnum
   {
      /// <remarks/>
      IntIR,
      /// <remarks/>
      IntSolar,
      /// <remarks/>
      IntVisible,
      /// <remarks/>
      IntTotal,
      /// <remarks/>
      ExtIR,
      /// <remarks/>
      ExtSolar,
      /// <remarks/>
      ExtVisible,
      /// <remarks/>
      ExtTotal,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum airTemperatureTypeEnum
   {
      /// <remarks/>
      Outside,
      /// <remarks/>
      Zone,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum resetTemperatureTypeEnum
   {
      /// <remarks/>
      None,
      /// <remarks/>
      Automatic,
      /// <remarks/>
      OutdoorAirBased,
      /// <remarks/>
      Scheduled,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum areaUnitEnum
   {
      /// <remarks/>
      SquareKilometers,
      /// <remarks/>
      SquareMeters,
      /// <remarks/>
      SquareCentimeters,
      /// <remarks/>
      SquareMillimeters,
      /// <remarks/>
      SquareMiles,
      /// <remarks/>
      SquareYards,
      /// <remarks/>
      SquareFeet,
      /// <remarks/>
      SquareInches,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum baseboardHeatingTypeEnum
   {
      /// <remarks/>
      ACH,
      /// <remarks/>
      HotWater,
      /// <remarks/>
      Electric,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum blowerDoorUnitEnum
   {
      /// <remarks/>
      ACH,
      /// <remarks/>
      AirChangesPerHour,
      /// <remarks/>
      SquareFeet,
      /// <remarks/>
      SquareMeter,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum buildingTypeEnum
   {
      /// <remarks/>
      AutomotiveFacility,
      /// <remarks/>
      ConventionCenter,
      /// <remarks/>
      Courthouse,
      /// <remarks/>
      DataCenter,
      /// <remarks/>
      DiningBarLoungeOrLeisure,
      /// <remarks/>
      DiningCafeteriaFastFood,
      /// <remarks/>
      DiningFamily,
      /// <remarks/>
      Dormitory,
      /// <remarks/>
      ExerciseCenter,
      /// <remarks/>
      FireStation,
      /// <remarks/>
      Gymnasium,
      /// <remarks/>
      HospitalOrHealthcare,
      /// <remarks/>
      Hotel,
      /// <remarks/>
      Library,
      /// <remarks/>
      Manufacturing,
      /// <remarks/>
      Motel,
      /// <remarks/>
      MotionPictureTheatre,
      /// <remarks/>
      MultiFamily,
      /// <remarks/>
      Museum,
      /// <remarks/>
      Office,
      /// <remarks/>
      ParkingGarage,
      /// <remarks/>
      Penitentiary,
      /// <remarks/>
      PerformingArtsTheater,
      /// <remarks/>
      PoliceStation,
      /// <remarks/>
      PostOffice,
      /// <remarks/>
      ReligiousBuilding,
      /// <remarks/>
      Retail,
      /// <remarks/>
      SchoolOrUniversity,
      /// <remarks/>
      SingleFamily,
      /// <remarks/>
      SportsArena,
      /// <remarks/>
      TownHall,
      /// <remarks/>
      Transportation,
      /// <remarks/>
      Unknown,
      /// <remarks/>
      Warehouse,
      /// <remarks/>
      Workshop,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum capacityTypeEnum
   {
      /// <remarks/>
      Heating,
      /// <remarks/>
      CoolingTotal,
      /// <remarks/>
      CoolingSensible,
      /// <remarks/>
      CoolingLatent,
      /// <remarks/>
      CoolingSHR,
      /// <remarks/>
      Volume,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum capacityUnitEnum
   {
      /// <remarks/>
      Tons,
      /// <remarks/>
      kW,
      /// <remarks/>
      BtuPerHour,
      /// <remarks/>
      kBtuPerHour,
      /// <remarks/>
      Gallons,
      /// <remarks/>
      Liters,
      /// <remarks/>
      CubicMeters,
      /// <remarks/>
      CubicFeet,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum conditioningUnitEnum
   {
      /// <remarks/>
      kBtu,
      /// <remarks/>
      Btu,
      /// <remarks/>
      kW,
      /// <remarks/>
      Tons,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum conditionTypeEnum
   {
      /// <remarks/>
      Heated,
      /// <remarks/>
      Cooled,
      /// <remarks/>
      HeatedAndCooled,
      /// <remarks/>
      Unconditioned,
      /// <remarks/>
      Vented,
      /// <remarks/>
      NaturallyVentedOnly,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum conditioningTypeEnum
   {
      /// <remarks/>
      Heating,
      /// <remarks/>
      Cooling,
      /// <remarks/>
      HeatingAndCooling,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum conductivityFofTUnitEnum
   {
      /// <remarks/>
      WPerMSquareK,
      /// <remarks/>
      BtuPerHourFtSquareF,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum conductivityUnitEnum
   {
      /// <remarks/>
      WPerCmC,
      /// <remarks/>
      WPerMeterK,
      /// <remarks/>
      BtuPerHourFtF,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum controlTypeEnum
   {
      /// <remarks/>
      Boiler,
      /// <remarks/>
      Chiller,
      /// <remarks/>
      Damper,
      /// <remarks/>
      Fan,
      /// <remarks/>
      Pump,
      /// <remarks/>
      Valve,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum coolingCoilSetpointResetTypeEnum
   {
      /// <remarks/>
      None,
      /// <remarks/>
      Warmest,
      /// <remarks/>
      OutdoorAirTemperatureReset,
      /// <remarks/>
      WarmestTemperatureFirst,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum coolingCoilTypeEnum
   {
      /// <remarks/>
      ChilledWater,
      /// <remarks/>
      ChilledWaterDetailedFlatModel,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum costTypeEnum
   {
      /// <remarks/>
      CO2,
      /// <remarks/>
      SOx,
      /// <remarks/>
      NOx,
      /// <remarks/>
      EmbodiedEnergyTransportation,
      /// <remarks/>
      EmbodiedEnergyManufacture,
      /// <remarks/>
      EmbodiedEnergyInstallation,
      /// <remarks/>
      EmbodiedEnergyTotal,
      /// <remarks/>
      PurchaseCost,
      /// <remarks/>
      DeliveryCost,
      /// <remarks/>
      FirstCost,
      /// <remarks/>
      MonthlyCost,
      /// <remarks/>
      AnnualCost,
      /// <remarks/>
      MaintenanceCost,
      /// <remarks/>
      OverhaulCost,
      /// <remarks/>
      InstallationCost,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum currencyTypeEnum
   {
      /// <remarks/>
      USDollars,
      /// <remarks/>
      CanadianDollars,
      /// <remarks/>
      Pesos,
      /// <remarks/>
      Euros,
      /// <remarks/>
      Yen,
      /// <remarks/>
      IndianRupee,
      /// <remarks/>
      Yuan,
      /// <remarks/>
      TaiwanDollar,
      /// <remarks/>
      EnglishPound,
      /// <remarks/>
      Mark,
      /// <remarks/>
      Franc,
      /// <remarks/>
      Ruble,
      /// <remarks/>
      Real,
      /// <remarks/>
      NewZealandDollar,
      /// <remarks/>
      AustralianDollar,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum damperHeatingActionEnum
   {
      /// <remarks/>
      Normal,
      /// <remarks/>
      Reverse,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum dayTypeEnum
   {
      /// <remarks/>
      Weekday,
      /// <remarks/>
      Weekend,
      /// <remarks/>
      Holiday,
      /// <remarks/>
      WeekendOrHoliday,
      /// <remarks/>
      HeatingDesignDay,
      /// <remarks/>
      CoolingDesignDay,
      /// <remarks/>
      Sun,
      /// <remarks/>
      Mon,
      /// <remarks/>
      Tue,
      /// <remarks/>
      Wed,
      /// <remarks/>
      Thu,
      /// <remarks/>
      Fri,
      /// <remarks/>
      Sat,
      /// <remarks/>
      Custom,
      /// <remarks/>
      All,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum defrostControlEnum
   {
      /// <remarks/>
      Timed,
      /// <remarks/>
      OnDemand,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum defrostStrategyEnum
   {
      /// <remarks/>
      ReverseCycle,
      /// <remarks/>
      Resistive,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum deltaPUnitEnum
   {
      /// <remarks/>
      PSI,
      /// <remarks/>
      kPa,
      /// <remarks/>
      Atmospheres,
      /// <remarks/>
      InchesOfH2O,
      /// <remarks/>
      CentimetersOfH2O,
      /// <remarks/>
      InchesOfMercury,
      /// <remarks/>
      CentimetersOfMercury,
      /// <remarks/>
      MillimetersOfMercury,
      /// <remarks/>
      Pascals,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum densityUnitEnum
   {
      /// <remarks/>
      GramsPerCubicCm,
      /// <remarks/>
      LbsPerCubicIn,
      /// <remarks/>
      LbsPerCubicFt,
      /// <remarks/>
      KgPerCubicM,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum densityFofTUnitEnum
   {
      /// <remarks/>
      LbsPerCubicFtF,
      /// <remarks/>
      KgPerCubicMK,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum directionUnitEnum
   {
      /// <remarks/>
      DegreeDecimalFromNorth,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum economizerLockoutEnum
   {
      /// <remarks/>
      NoLockout,
      /// <remarks/>
      LockoutWithHeating,
      /// <remarks/>
      LockoutWithCompressor,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum enthalpyTypeEnum
   {
      /// <remarks/>
      EconomizerUpperLimit,
      /// <remarks/>
      AirSideEconomizerMinSetpoint,
      /// <remarks/>
      EconomizerMaxLimit,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum enthalpyUnitEnum
   {
      /// <remarks/>
      BTUPerLb,
      /// <remarks/>
      KJPerKg,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum equipmentTypeEnum
   {
      /// <remarks/>
      Fan,
      /// <remarks/>
      HeatExchanger,
      /// <remarks/>
      Coil,
      /// <remarks/>
      Furnace,
      /// <remarks/>
      Evaporative,
      /// <remarks/>
      Radiant,
      /// <remarks/>
      Economizer,
      /// <remarks/>
      Duct,
      /// <remarks/>
      Humidifier,
      /// <remarks/>
      Dehumidifier,
      /// <remarks/>
      UnitaryAC,
      /// <remarks/>
      UnitaryHP,
      /// <remarks/>
      SplitAC,
      /// <remarks/>
      SplitHP,
      /// <remarks/>
      TerminalUnit,
      /// <remarks/>
      Register,
      /// <remarks/>
      VAVBox,
      /// <remarks/>
      EvaporativePreCooler,
      /// <remarks/>
      PreheatCoil,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum efficiencyTypeEnum
   {
      /// <remarks/>
      COP,
      /// <remarks/>
      EER,
      /// <remarks/>
      SEER,
      /// <remarks/>
      AFUE,
      /// <remarks/>
      HSPF,
      /// <remarks/>
      effectiveness,
      /// <remarks/>
      EnergyFactor,
      /// <remarks/>
      ThermalEff,
      /// <remarks/>
      MotorEff,
      /// <remarks/>
      FanEff,
      /// <remarks/>
      MechanicalEff,
      /// <remarks/>
      BoilerEff,
      /// <remarks/>
      kWPerTon,
      /// <remarks/>
      kWPerkW,
      /// <remarks/>
      BTUPerHourPerF,
      /// <remarks/>
      kWPerC,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum emissionUnitEnum
   {
      /// <remarks/>
      PoundsPerHour,
      /// <remarks/>
      KilogramsPerHour,
      /// <remarks/>
      GramsPerHour,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum emittanceTypeEnum
   {
      /// <remarks/>
      IntIR,
      /// <remarks/>
      ExtIR,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum energyUnitEnum
   {
      /// <remarks/>
      KilowattHours,
      /// <remarks/>
      Joules,
      /// <remarks/>
      BTU,
      /// <remarks/>
      Therms,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum entityTypeEnum
   {
      /// <remarks/>
      File,
      /// <remarks/>
      Model,
      /// <remarks/>
      Project,
      /// <remarks/>
      Run,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum extEquipTypeEnum
   {
      /// <remarks/>
      Sprinkler,
      /// <remarks/>
      LawnMower,
      /// <remarks/>
      GeneralPlugload,
      /// <remarks/>
      Fountain,
      /// <remarks/>
      Refrigerator,
      /// <remarks/>
      Freezer,
      /// <remarks/>
      Pool,
      /// <remarks/>
      HotTub,
      /// <remarks/>
      Pump,
      /// <remarks/>
      Sauna,
      /// <remarks/>
      BatteryCharger,
      /// <remarks/>
      Furnace,
      /// <remarks/>
      IndustrialEquip,
      /// <remarks/>
      Irrigation,
      /// <remarks/>
      MiscEquip,
      /// <remarks/>
      Vending,
      /// <remarks/>
      Elevator,
      /// <remarks/>
      Escalator,
      /// <remarks/>
      WindTurbine,
      /// <remarks/>
      Photovoltaic,
      /// <remarks/>
      CogenDiesel,
      /// <remarks/>
      CogenFuelCell,
      /// <remarks/>
      CogenGasTurbine,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum floorCategoryEnum
   {
      /// <remarks/>
      OverEnclosedCrawlSpaceOrBasement,
      /// <remarks/>
      OverOpenCrawlSpaceOrGarage,
      /// <remarks/>
      Basement,
      /// <remarks/>
      SlabOnGrade,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum floorSlabPerimeterHeatLossCoefficientUnitTypeEnum
   {
      /// <remarks/>
      btuPerHourDegreeFPerLinearFoot,
      /// <remarks/>
      wattDegreeCPerLinearMeter,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum flowUnitEnum
   {
      /// <remarks/>
      CFM,
      /// <remarks/>
      CubicMPerHr,
      /// <remarks/>
      LPerSec,
      /// <remarks/>
      LPM,
      /// <remarks/>
      GPH,
      /// <remarks/>
      GPM,
      /// <remarks/>
      Fraction,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum flowPerAreaUnitEnum
   {
      /// <remarks/>
      CFMPerSquareFoot,
      /// <remarks/>
      LPerSecPerSquareM,
      /// <remarks/>
      CubicMPerSecPerSquareM,
      /// <remarks/>
      CubicMPerHourPerSquareM,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum flowTypeEnum
   {
      /// <remarks/>
      Series,
      /// <remarks/>
      Parallel,
      /// <remarks/>
      SeriesFromPlenum,
      /// <remarks/>
      ParallelFromPlenum,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum fluidTypeEnum
   {
      /// <remarks/>
      Water,
      /// <remarks/>
      Brine,
      /// <remarks/>
      Glycol,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum frameTypeEnum
   {
      /// <remarks/>
      Wood,
      /// <remarks/>
      Vinyl,
      /// <remarks/>
      Aluminum,
      /// <remarks/>
      AluminumWithBreak,
      /// <remarks/>
      Insulated,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum fuelLoadUnitEnum
   {
      /// <remarks/>
      BtuPerHour,
      /// <remarks/>
      kBtuPerHour,
      /// <remarks/>
      MBtuPerHour,
      /// <remarks/>
      Watts,
      /// <remarks/>
      kW,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum gasTypeEnum
   {
      /// <remarks/>
      Air,
      /// <remarks/>
      Argon,
      /// <remarks/>
      Krypton,
      /// <remarks/>
      CO2,
      /// <remarks/>
      SF6,
      /// <remarks/>
      Custom,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum heatingCoilSetpointResetTypeEnum
   {
      /// <remarks/>
      None,
      /// <remarks/>
      OutdoorAirTemperatureReset,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum heatRecoveryTypeEnum
   {
      /// <remarks/>
      None,
      /// <remarks/>
      Sensible,
      /// <remarks/>
      Enthalpy,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum hOutsideUnitTypeEnum
   {
      /// <remarks/>
      BTUPerHourSquareFootDegreeF,
      /// <remarks/>
      WattsPerSecondSquareMeterDegreeC,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum hydronicEquipTypeEnum
   {
      /// <remarks/>
      Chiller,
      /// <remarks/>
      CoolingTower,
      /// <remarks/>
      Condenser,
      /// <remarks/>
      Boiler,
      /// <remarks/>
      HeatExchanger,
      /// <remarks/>
      Pump,
      /// <remarks/>
      RadiantPanel,
      /// <remarks/>
      HotWaterHeater,
      /// <remarks/>
      SolarPanels,
      /// <remarks/>
      Earth,
      /// <remarks/>
      Pipe,
      /// <remarks/>
      Storage,
      /// <remarks/>
      Coil,
      /// <remarks/>
      Radiator,
      /// <remarks/>
      TwoWayValve,
      /// <remarks/>
      ThreeWayValve,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum illuminanceUnitEnum
   {
      /// <remarks/>
      Footcandles,
      /// <remarks/>
      Lux,
      /// <remarks/>
      Phot,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum infiltrationTypeEnum
   {
      /// <remarks/>
      Loose,
      /// <remarks/>
      Average,
      /// <remarks/>
      Tight,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum intEquipTypeEnum
   {
      /// <remarks/>
      GeneralPlugload,
      /// <remarks/>
      Computer,
      /// <remarks/>
      Copier,
      /// <remarks/>
      Refrigerator,
      /// <remarks/>
      Stove,
      /// <remarks/>
      Cooktop,
      /// <remarks/>
      Fryer,
      /// <remarks/>
      Freezer,
      /// <remarks/>
      ClothesDryer,
      /// <remarks/>
      ClothesWasher,
      /// <remarks/>
      Dishwasher,
      /// <remarks/>
      TV,
      /// <remarks/>
      VCR,
      /// <remarks/>
      Microwave,
      /// <remarks/>
      Fan,
      /// <remarks/>
      AudioEquip,
      /// <remarks/>
      MiscEquip,
      /// <remarks/>
      Toilet,
      /// <remarks/>
      Urinal,
      /// <remarks/>
      Shower,
      /// <remarks/>
      Sink,
      /// <remarks/>
      Pool,
      /// <remarks/>
      HotTub,
      /// <remarks/>
      Sauna,
      /// <remarks/>
      BatteryCharger,
      /// <remarks/>
      Furnace,
      /// <remarks/>
      IndustrialEquip,
      /// <remarks/>
      Printer,
      /// <remarks/>
      Vending,
      /// <remarks/>
      Elevator,
      /// <remarks/>
      Escalator,
      /// <remarks/>
      GeneralLaundryEquip,
      /// <remarks/>
      GeneralKitchenEquip,
      /// <remarks/>
      GeneralMedicalEquip,
      /// <remarks/>
      GeneralOfficeEquip,
      /// <remarks/>
      GeneralEntertainmentEquip,
      /// <remarks/>
      GeneralRefrigerationEquip,
      /// <remarks/>
      GeneralFitnessEquip,
      /// <remarks/>
      GeneralVideoEquip,
      /// <remarks/>
      GeneralToilet,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum inverseTempUnitEnum
   {
      /// <remarks/>
      PerK,
      /// <remarks/>
      PerF,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum lengthUnitEnum
   {
      /// <remarks/>
      Kilometers,
      /// <remarks/>
      Meters,
      /// <remarks/>
      Centimeters,
      /// <remarks/>
      Millimeters,
      /// <remarks/>
      Miles,
      /// <remarks/>
      Yards,
      /// <remarks/>
      Feet,
      /// <remarks/>
      Inches,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum lifeUnitEnum
   {
      /// <remarks/>
      Months,
      /// <remarks/>
      Years,
      /// <remarks/>
      Cycles,
      /// <remarks/>
      MillionCycles,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum lightControlTypeEnum
   {
      /// <remarks/>
      Continuous,
      /// <remarks/>
      OnOff,
      /// <remarks/>
      Stepped2,
      /// <remarks/>
      Stepped3,
      /// <remarks/>
      Stepped4,
      /// <remarks/>
      Stepped5,
      /// <remarks/>
      Stepped6,
      /// <remarks/>
      Stepped7,
      /// <remarks/>
      Stepped8,
      /// <remarks/>
      Stepped9,
      /// <remarks/>
      Stepped10,
      /// <remarks/>
      Stepped11,
      /// <remarks/>
      Stepped12,
      /// <remarks/>
      Stepped13,
      /// <remarks/>
      Stepped14,
      /// <remarks/>
      Stepped15,
      /// <remarks/>
      Stepped16,
      /// <remarks/>
      Stepped17,
      /// <remarks/>
      Stepped18,
      /// <remarks/>
      Stepped19,
      /// <remarks/>
      Stepped20,
      /// <remarks/>
      ContinuousOff,
      /// <remarks/>
      MotionSensor,
      /// <remarks/>
      Photocell,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum loadUnitEnum
   {
      /// <remarks/>
      BtuPerHour,
      /// <remarks/>
      Watt,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum loopTypeEnum
   {
      /// <remarks/>
      PrimaryChilledWater,
      /// <remarks/>
      SecondaryChilledWater,
      /// <remarks/>
      HotWater,
      /// <remarks/>
      CondenserWater,
      /// <remarks/>
      DomesticHotWater,
      /// <remarks/>
      WaterLoopHeatPump,
      /// <remarks/>
      TwoPipe,
      /// <remarks/>
      PotableWaterLoop,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum minimumOutdoorAirControlTypeEnum
   {
      /// <remarks/>
      FixedMinimum,
      /// <remarks/>
      ProportionalMinimum,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum nightCycleControlEnum
   {
      /// <remarks/>
      StayOff,
      /// <remarks/>
      CycleOnAny,
      /// <remarks/>
      CycleOnControlZone,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum openingTypeEnum
   {
      /// <remarks/>
      FixedWindow,
      /// <remarks/>
      OperableWindow,
      /// <remarks/>
      FixedSkylight,
      /// <remarks/>
      OperableSkylight,
      /// <remarks/>
      SlidingDoor,
      /// <remarks/>
      NonSlidingDoor,
      /// <remarks/>
      Air,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum operationTypeEnum
   {
      /// <remarks/>
      Cycling,
      /// <remarks/>
      Continuous,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum peopleHeatGainUnitEnum
   {
      /// <remarks/>
      WattPerPerson,
      /// <remarks/>
      BtuPerHourPerson,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum peopleHeatGainTypeEnum
   {
      /// <remarks/>
      Total,
      /// <remarks/>
      Sensible,
      /// <remarks/>
      Latent,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum peopleNumberUnitEnum
   {
      /// <remarks/>
      NumberOfPeople,
      /// <remarks/>
      SquareFtPerPerson,
      /// <remarks/>
      SquareMPerPerson,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum permUnitEnum
   {
      /// <remarks/>
      PermSI,
      /// <remarks/>
      PermIP,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum powerTypeEnum
   {
      /// <remarks/>
      Electricity,
      /// <remarks/>
      NaturalGas,
      /// <remarks/>
      Propane,
      /// <remarks/>
      FuelOil1,
      /// <remarks/>
      FuelOil2,
      /// <remarks/>
      FuelOil4,
      /// <remarks/>
      Water,
      /// <remarks/>
      ChilledWater,
      /// <remarks/>
      HotWater,
      /// <remarks/>
      Steam,
      /// <remarks/>
      Diesel,
      /// <remarks/>
      Biogas,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum powerUnitEnum
   {
      /// <remarks/>
      Watt,
      /// <remarks/>
      Kilowatt,
      /// <remarks/>
      Horsepower,
      /// <remarks/>
      KilogramForceMeterPerSecond,
      /// <remarks/>
      BtuPerSecond,
      /// <remarks/>
      FootPoundForcePerSecond,
      /// <remarks/>
      KilocaloriesPerSecond,
      /// <remarks/>
      BtuPerHour,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum powerUseTypeEnum
   {
      /// <remarks/>
      Heating,
      /// <remarks/>
      Cooling,
      /// <remarks/>
      Both,
      /// <remarks/>
      ElectricityGeneration,
      /// <remarks/>
      Other,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum powerPerAreaUnitEnum
   {
      /// <remarks/>
      WattPerSquareMeter,
      /// <remarks/>
      WattPerSquareFoot,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum preheatCoilTypeEnum
   {
      /// <remarks/>
      None,
      /// <remarks/>
      Electric,
      /// <remarks/>
      Gas,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum pressureUnitEnum
   {
      /// <remarks/>
      PSI,
      /// <remarks/>
      kPa,
      /// <remarks/>
      Atmospheres,
      /// <remarks/>
      InchesOfH2O,
      /// <remarks/>
      CentimetersOfH2O,
      /// <remarks/>
      InchesOfMercury,
      /// <remarks/>
      CentimetersOfMercury,
      /// <remarks/>
      MillimetersOfMercury,
      /// <remarks/>
      Pascals,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum radiationWavelengthTypeEnum
   {
      /// <remarks/>
      Solar,
      /// <remarks/>
      IR,
      /// <remarks/>
      Visible,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum reflectanceTypeEnum
   {
      /// <remarks/>
      Ground,
      /// <remarks/>
      IntSolar,
      /// <remarks/>
      IntIR,
      /// <remarks/>
      IntVisible,
      /// <remarks/>
      ExtSolar,
      /// <remarks/>
      ExtVisible,
      /// <remarks/>
      ExtIR,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum resistanceUnitEnum
   {
      /// <remarks/>
      SquareMeterKPerW,
      /// <remarks/>
      HrSquareFtFPerBTU,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum uValueUnitEnum
   {
      /// <remarks/>
      WPerSquareMeterK,
      /// <remarks/>
      BtuPerHourSquareFtF,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum resourceTypeEnum
   {
      /// <remarks/>
      Electricity,
      /// <remarks/>
      NaturalGas,
      /// <remarks/>
      Propane,
      /// <remarks/>
      FuelOil1,
      /// <remarks/>
      FuelOil2,
      /// <remarks/>
      FuelOil4,
      /// <remarks/>
      Water,
      /// <remarks/>
      ChilledWater,
      /// <remarks/>
      HotWater,
      /// <remarks/>
      Steam,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum resultsExtraResourceTypeEnum
   {
      /// <remarks/>
      Thermal,
      /// <remarks/>
      Light,
      /// <remarks/>
      Moisture,
      /// <remarks/>
      Air,
      /// <remarks/>
      Contaminant,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum resultsTypeEnum
   {
      /// <remarks/>
      HeatLoad,
      /// <remarks/>
      CoolingLoad,
      /// <remarks/>
      CO2,
      /// <remarks/>
      SO2,
      /// <remarks/>
      NOx,
      /// <remarks/>
      Energy,
      /// <remarks/>
      Power,
      /// <remarks/>
      Cost,
      /// <remarks/>
      EnergyCost,
      /// <remarks/>
      DemandCost,
      /// <remarks/>
      CommodityCost,
      /// <remarks/>
      TransportationCost,
      /// <remarks/>
      DryBulbTemperature,
      /// <remarks/>
      WetBulbTemperature,
      /// <remarks/>
      DewPointTemperature,
      /// <remarks/>
      FootCandles,
      /// <remarks/>
      Humidity,
      /// <remarks/>
      MoistureContent,
      /// <remarks/>
      Flow,
      /// <remarks/>
      Capacity,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum roofASHRAENumberEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("0")]
      Item0,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("1")]
      Item1,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("2")]
      Item2,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("3")]
      Item3,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("4")]
      Item4,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5")]
      Item5,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("6")]
      Item6,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("7")]
      Item7,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("8")]
      Item8,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("9")]
      Item9,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("10")]
      Item10,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("11")]
      Item11,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("12")]
      Item12,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("13")]
      Item13,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum roofCLTDIndexEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("1")]
      Item1,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("2")]
      Item2,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("3")]
      Item3,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("4")]
      Item4,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5")]
      Item5,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("6")]
      Item6,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("7")]
      Item7,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("8")]
      Item8,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("9")]
      Item9,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("10")]
      Item10,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("11")]
      Item11,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("12")]
      Item12,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("13")]
      Item13,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("14")]
      Item14,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("15")]
      Item15,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("16")]
      Item16,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("17")]
      Item17,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("18")]
      Item18,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("19")]
      Item19,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("20")]
      Item20,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("21")]
      Item21,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("22")]
      Item22,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("23")]
      Item23,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("24")]
      Item24,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("25")]
      Item25,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("26")]
      Item26,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("27")]
      Item27,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("28")]
      Item28,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("29")]
      Item29,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("30")]
      Item30,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("31")]
      Item31,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("32")]
      Item32,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("33")]
      Item33,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("34")]
      Item34,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("35")]
      Item35,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("36")]
      Item36,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("37")]
      Item37,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("38")]
      Item38,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("39")]
      Item39,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("40")]
      Item40,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("41")]
      Item41,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("42")]
      Item42,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("43")]
      Item43,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("44")]
      Item44,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("45")]
      Item45,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("46")]
      Item46,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("47")]
      Item47,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum roofColorEnum
   {
      /// <remarks/>
      Dark,
      /// <remarks/>
      Light,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum roofCTSTypeEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("1")]
      Item1,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("2")]
      Item2,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("3")]
      Item3,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("4")]
      Item4,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5")]
      Item5,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("6")]
      Item6,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("7")]
      Item7,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("8")]
      Item8,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("9")]
      Item9,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("10")]
      Item10,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("11")]
      Item11,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("12")]
      Item12,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("13")]
      Item13,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("14")]
      Item14,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("15")]
      Item15,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("16")]
      Item16,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("17")]
      Item17,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("18")]
      Item18,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("19")]
      Item19,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum roughnessValueEnum
   {
      /// <remarks/>
      VeryRough,
      /// <remarks/>
      MediumRough,
      /// <remarks/>
      Rough,
      /// <remarks/>
      Smooth,
      /// <remarks/>
      MediumSmooth,
      /// <remarks/>
      VerySmooth,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum scheduleTypeEnum
   {
      /// <remarks/>
      Temp,
      /// <remarks/>
      Fraction,
      /// <remarks/>
      OnOff,
      /// <remarks/>
      ResetTemp,
      /// <remarks/>
      ActivityLevel,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum scheduleTypeLimitsEnum
   {
      /// <remarks/>
      Continuous,
      /// <remarks/>
      Discrete,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum shadeTypeEnum
   {
      /// <remarks/>
      InteriorInsulated,
      /// <remarks/>
      InteriorUnInsulated,
      /// <remarks/>
      ExternalInsulated,
      /// <remarks/>
      ExternalUnInsulated,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum shadeOperationEnum
   {
      /// <remarks/>
      Fixed,
      /// <remarks/>
      Operable,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum shadeScheduleTypeEnum
   {
      /// <remarks/>
      Shade,
      /// <remarks/>
      Blind,
      /// <remarks/>
      Operation,
      /// <remarks/>
      Probability,
      /// <remarks/>
      MaxSolar,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum sinkRateUnitEnum
   {
      /// <remarks/>
      PoundsPerHour,
      /// <remarks/>
      KilogramsPerHour,
      /// <remarks/>
      GramsPerHour,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum spaceTypeEnum
   {
      /// <remarks/>
      ActiveStorage,
      /// <remarks/>
      ActiveStorageHospitalOrHealthcare,
      /// <remarks/>
      AirOrTrainOrBusBaggageArea,
      /// <remarks/>
      AirportConcourse,
      /// <remarks/>
      AtriumEachAdditionalFloor,
      /// <remarks/>
      AtriumFirstThreeFloors,
      /// <remarks/>
      AudienceOrSeatingAreaPenitentiary,
      /// <remarks/>
      AudienceOrSeatingAreaExerciseCenter,
      /// <remarks/>
      AudienceOrSeatingAreaGymnasium,
      /// <remarks/>
      AudienceOrSeatingAreaSportsArena,
      /// <remarks/>
      AudienceOrSeatingAreaConventionCenter,
      /// <remarks/>
      AudienceOrSeatingAreaMotionPictureTheatre,
      /// <remarks/>
      AudienceOrSeatingAreaPerformingArtsTheatre,
      /// <remarks/>
      AudienceOrSeatingAreaReligious,
      /// <remarks/>
      AudienceOrSeatingAreaPoliceOrFireStations,
      /// <remarks/>
      AudienceOrSeatingAreaCourtHouse,
      /// <remarks/>
      AudienceOrSeatingAreaAuditorium,
      /// <remarks/>
      BankCustomerArea,
      /// <remarks/>
      BankingActivityAreaOffice,
      /// <remarks/>
      BarberAndBeautyParlor,
      /// <remarks/>
      CardFileAndCataloguingLibrary,
      /// <remarks/>
      ClassroomOrLectureOrTrainingPenitentiary,
      /// <remarks/>
      ClassroomOrLectureOrTraining,
      /// <remarks/>
      ConfinementCellsPenitentiary,
      /// <remarks/>
      ConfinementCellsCourtHouse,
      /// <remarks/>
      ConferenceMeetingOrMultipurpose,
      /// <remarks/>
      CorridorOrTransition,
      /// <remarks/>
      CorridorOrTransitionManufacturingFacility,
      /// <remarks/>
      CorridorsWithPatientWaitingExamHospitalOrHealthcare,
      /// <remarks/>
      CourtSportsAreaSportsArena,
      /// <remarks/>
      CourtroomCourtHouse,
      /// <remarks/>
      DepartmentStoreSalesAreaRetail,
      /// <remarks/>
      DetailedManufacturingFacility,
      /// <remarks/>
      DiningArea,
      /// <remarks/>
      DiningAreaHotel,
      /// <remarks/>
      DiningAreaFamilyDining,
      /// <remarks/>
      DiningAreaLoungeOrLeisureDining,
      /// <remarks/>
      DiningAreaMotel,
      /// <remarks/>
      DiningAreaTransportation,
      /// <remarks/>
      DiningAreaPenitentiary,
      /// <remarks/>
      DiningAreaCivilServices,
      /// <remarks/>
      DormitoryBedroom,
      /// <remarks/>
      DormitoryStudyHall,
      /// <remarks/>
      DressingOrLockerOrFittingRoomGymnasium,
      /// <remarks/>
      DressingOrLockerOrFittingRoomCourtHouse,
      /// <remarks/>
      DressingOrLockerOrFittingRoomPerformingArtsTheatre,
      /// <remarks/>
      DressingOrLockerOrFittingRoomAuditorium,
      /// <remarks/>
      DressingOrLockerOrFittingRoomExerciseCenter,
      /// <remarks/>
      ElectricalOrMechanical,
      /// <remarks/>
      ElevatorLobbies,
      /// <remarks/>
      EmergencyHospitalOrHealthcare,
      /// <remarks/>
      EquipmentRoomManufacturingFacility,
      /// <remarks/>
      ExamOrTreatmentHospitalOrHealthcare,
      /// <remarks/>
      ExcerciseAreaExerciseCenter,
      /// <remarks/>
      ExcerciseAreaGymnasium,
      /// <remarks/>
      ExhibitSpaceConventionCenter,
      /// <remarks/>
      FellowshipHallReligiousBuildings,
      /// <remarks/>
      FineMaterialWarehouse,
      /// <remarks/>
      FineMerchandiseSalesAreaRetail,
      /// <remarks/>
      FireStationEngineRoomPoliceOrFireStation,
      /// <remarks/>
      FoodPreparation,
      /// <remarks/>
      GarageServiceOrRepairAutomotiveFacility,
      /// <remarks/>
      GeneralHighBayManufacturingFacility,
      /// <remarks/>
      GeneralLowBayManufacturingFacility,
      /// <remarks/>
      GeneralExhibitionMuseum,
      /// <remarks/>
      HospitalNurseryHospitalOrHealthcare,
      /// <remarks/>
      HospitalOrMedicalSuppliesHospitalOrHealthcare,
      /// <remarks/>
      HospitalOrRadiologyHospitalOrHealthcare,
      /// <remarks/>
      HotelOrConferenceCenterConferenceOrMeeting,
      /// <remarks/>
      InactiveStorage,
      /// <remarks/>
      JudgesChambersCourtHouse,
      /// <remarks/>
      LaboratoryOffice,
      /// <remarks/>
      LaundryIroningAndSorting,
      /// <remarks/>
      LaundryWashingHospitalOrHealthcare,
      /// <remarks/>
      LibraryAudioVisualLibraryAudioVisual,
      /// <remarks/>
      LivingQuartersDormitory,
      /// <remarks/>
      LivingQuartersMotel,
      /// <remarks/>
      LivingQuartersHotel,
      /// <remarks/>
      Lobby,
      /// <remarks/>
      LobbyReligiousBuildings,
      /// <remarks/>
      LobbyMotionPictureTheatre,
      /// <remarks/>
      LobbyAuditorium,
      /// <remarks/>
      LobbyPerformingArtsTheatre,
      /// <remarks/>
      LobbyPostOffice,
      /// <remarks/>
      LobbyHotel,
      /// <remarks/>
      LoungeOrRecreation,
      /// <remarks/>
      MallConcourseSalesAreaRetail,
      /// <remarks/>
      MassMerchandisingSalesAreaRetail,
      /// <remarks/>
      MediumOrBulkyMaterialWarehouse,
      /// <remarks/>
      MerchandisingSalesAreaRetail,
      /// <remarks/>
      MuseumAndGalleryStorage,
      /// <remarks/>
      NurseStationHospitalOrHealthcare,
      /// <remarks/>
      OfficeEnclosed,
      /// <remarks/>
      OfficeOpenPlan,
      /// <remarks/>
      OfficeCommonActivityAreasInactiveStorage,
      /// <remarks/>
      OperatingRoomHospitalOrHealthcare,
      /// <remarks/>
      OtherTelevisedPlayingAreaSportsArena,
      /// <remarks/>
      ParkingAreaAttendantOnlyParkingGarage,
      /// <remarks/>
      ParkingAreaPedestrianParkingGarage,
      /// <remarks/>
      PatientRoomHospitalOrHealthcare,
      /// <remarks/>
      PersonalServicesSalesAreaRetail,
      /// <remarks/>
      PharmacyHospitalOrHealthcare,
      /// <remarks/>
      PhysicalTherapyHospitalOrHealthcare,
      /// <remarks/>
      PlayingAreaGymnasium,
      /// <remarks/>
      Plenum,
      /// <remarks/>
      PoliceStationLaboratoryPoliceOrFireStations,
      /// <remarks/>
      PublicAndStaffLoungeHospitalOrHealthcare,
      /// <remarks/>
      ReadingAreaLibrary,
      /// <remarks/>
      ReceptionOrWaitingTransportation,
      /// <remarks/>
      ReceptionOrWaitingMotel,
      /// <remarks/>
      ReceptionOrWaitingHotel,
      /// <remarks/>
      RecoveryHospitalOrHealthcare,
      /// <remarks/>
      RestorationMuseum,
      /// <remarks/>
      Restrooms,
      /// <remarks/>
      RingSportsAreaSportsArena,
      /// <remarks/>
      ServerRoom,
      /// <remarks/>
      SleepingQuartersPoliceOrFireStation,
      /// <remarks/>
      SortingAreaPostOffice,
      /// <remarks/>
      SpecialtyStoreSalesAreaRetail,
      /// <remarks/>
      StacksLibrary,
      /// <remarks/>
      StairsInactive,
      /// <remarks/>
      Stairway,
      /// <remarks/>
      SupermarketSalesAreaRetail,
      /// <remarks/>
      TerminalTicketCounterTransportation,
      /// <remarks/>
      WorkshopWorkshop,
      /// <remarks/>
      WorshipPulpitChoirReligious,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum specificHeatUnitEnum
   {
      /// <remarks/>
      JPerKgK,
      /// <remarks/>
      BTUPerLbF,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum stageTypeEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("1Stage")]
      Item1Stage,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("2Stage")]
      Item2Stage,
      /// <remarks/>
      Variable,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum standardsTypeEnum
   {
      /// <remarks/>
      DOE,
      /// <remarks/>
      ARI,
      /// <remarks/>
      ANSI,
      /// <remarks/>
      NEMA,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum stationIdTypeEnum
   {
      /// <remarks/>
      WMO,
      /// <remarks/>
      WBAN,
      /// <remarks/>
      ICAO,
      /// <remarks/>
      NWSLI,
      /// <remarks/>
      FAACallSign,
      /// <remarks/>
      COOP,
      /// <remarks/>
      Modeled,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum supplementalHeatingCoilTypeEnum
   {
      /// <remarks/>
      Electric,
      /// <remarks/>
      Gas,
      /// <remarks/>
      HotWater,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum surfaceDescriptionEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("1")]
      Item1,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("2")]
      Item2,
      /// <remarks/>
      Both,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum surfaceTypeEnum
   {
      /// <remarks/>
      InteriorWall,
      /// <remarks/>
      ExteriorWall,
      /// <remarks/>
      Roof,
      /// <remarks/>
      InteriorFloor,
      /// <remarks/>
      ExposedFloor,
      /// <remarks/>
      Shade,
      /// <remarks/>
      UndergroundWall,
      /// <remarks/>
      UndergroundSlab,
      /// <remarks/>
      Ceiling,
      /// <remarks/>
      Air,
      /// <remarks/>
      UndergroundCeiling,
      /// <remarks/>
      RaisedFloor,
      /// <remarks/>
      SlabOnGrade,
      /// <remarks/>
      FreestandingColumn,
      /// <remarks/>
      EmbeddedColumn,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum systemTypeEnum
   {
      /// <remarks/>
      SingleZoneReheat,
      /// <remarks/>
      PackagedSingleZone,
      /// <remarks/>
      SingleZoneCeilingInduction,
      /// <remarks/>
      ReheatFan,
      /// <remarks/>
      VariableAirVolume,
      /// <remarks/>
      PoweredInductionUnit,
      /// <remarks/>
      PackagedVariableAirVolume,
      /// <remarks/>
      PackagedVariableVolumeVariableTemperature,
      /// <remarks/>
      CeilingBypassVariableAirVolume,
      /// <remarks/>
      EvaporativeCooling,
      /// <remarks/>
      MultiZone,
      /// <remarks/>
      PackagedMultiZone,
      /// <remarks/>
      DualDuct,
      /// <remarks/>
      FanCoil,
      /// <remarks/>
      InductionUnit,
      /// <remarks/>
      PackagedTerminalAirConditioner,
      /// <remarks/>
      WaterLoopHeatPump,
      /// <remarks/>
      ResidentialCyclingFurnaceCyclingAC,
      /// <remarks/>
      ResidentialVariableAirVolumeVariableTemperature,
      /// <remarks/>
      FloorPanelHeating,
      /// <remarks/>
      HeatingAndVentilating,
      /// <remarks/>
      UnitHeater,
      /// <remarks/>
      UnitVentilator,
      /// <remarks/>
      CentralHeatingRadiators,
      /// <remarks/>
      CentralHeatingConvectors,
      /// <remarks/>
      CentralHeatingRadiantFloor,
      /// <remarks/>
      CentralHeatingHotAir,
      /// <remarks/>
      OtherRoomHeater,
      /// <remarks/>
      RadiantHeaterNoFlue,
      /// <remarks/>
      RadiantHeaterFlue,
      /// <remarks/>
      RadiantHeaterMultiburner,
      /// <remarks/>
      ForcedConvectionHeaterFlue,
      /// <remarks/>
      ForcedConvectionHeaterNoFlue,
      /// <remarks/>
      VAVSingleDuct,
      /// <remarks/>
      VAVDualDuct,
      /// <remarks/>
      VAVReheatFan,
      /// <remarks/>
      VAVIndoorPackagedCabinet,
      /// <remarks/>
      ConstantVolumeFixedOA,
      /// <remarks/>
      ConstantVolumeVariableOA,
      /// <remarks/>
      ConstantVolumeTerminalReheat,
      /// <remarks/>
      MultizoneHotDeckColdDeck,
      /// <remarks/>
      ConstantVolumeDualDuct,
      /// <remarks/>
      RadiantCooledCeilings,
      /// <remarks/>
      ActiveChilledBeams,
      /// <remarks/>
      VariableRefrigerantFlow,
      /// <remarks/>
      SplitSystemsWithNaturalVentilation,
      /// <remarks/>
      SplitSystemsWithMechanicalVentilation,
      /// <remarks/>
      SplitSystemsWithMechanicalVentilationWithCooling,
      /// <remarks/>
      Exhaust,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum temperatureUnitEnum
   {
      /// <remarks/>
      F,
      /// <remarks/>
      C,
      /// <remarks/>
      K,
      /// <remarks/>
      R,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum tempTypeEnum
   {
      /// <remarks/>
      Max,
      /// <remarks/>
      Min,
      /// <remarks/>
      Design,
      /// <remarks/>
      CoolDesign,
      /// <remarks/>
      HeatDesign,
      /// <remarks/>
      Throttle,
      /// <remarks/>
      Range,
      /// <remarks/>
      Approach,
      /// <remarks/>
      EnteringWetBulb,
      /// <remarks/>
      LeavingDryBulb,
      /// <remarks/>
      EnteringDryBulb,
      /// <remarks/>
      LeavingWetBulb,
      /// <remarks/>
      ChilledWaterSupply,
      /// <remarks/>
      CondenserWaterSupply,
      /// <remarks/>
      LeavingChilledWater,
      /// <remarks/>
      LeavingCondenserWater,
      /// <remarks/>
      HighTempLockout,
      /// <remarks/>
      LowTempLockout,
      /// <remarks/>
      EconomizerMaxLimitDewpoint,
      /// <remarks/>
      HeatPumpDefrostMaxOADryBulb,
      /// <remarks/>
      SupplementalHeatingCoilMaxOADryBulb,
      /// <remarks/>
      PreheatCoilDesignSetpoint,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum timePeriodEnum
   {
      /// <remarks/>
      Annual,
      /// <remarks/>
      Jan,
      /// <remarks/>
      Feb,
      /// <remarks/>
      Mar,
      /// <remarks/>
      Apr,
      /// <remarks/>
      May,
      /// <remarks/>
      Jun,
      /// <remarks/>
      Jul,
      /// <remarks/>
      Aug,
      /// <remarks/>
      Sep,
      /// <remarks/>
      Oct,
      /// <remarks/>
      Nov,
      /// <remarks/>
      Dec,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum timeUnitEnum
   {
      /// <remarks/>
      Year,
      /// <remarks/>
      Month,
      /// <remarks/>
      Week,
      /// <remarks/>
      Day,
      /// <remarks/>
      Hour,
      /// <remarks/>
      Minute,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum transportationTypeEnum
   {
      /// <remarks/>
      Bus,
      /// <remarks/>
      Train,
      /// <remarks/>
      Car,
      /// <remarks/>
      LightRail,
      /// <remarks/>
      Ferry,
      /// <remarks/>
      Airplane,
      /// <remarks/>
      Monorail,
      /// <remarks/>
      Bike,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum unitlessSmallUnitEnum
   {
      /// <remarks/>
      Percent,
      /// <remarks/>
      PartPerMillionByVolume,
      /// <remarks/>
      milliGramsPerCubicMeter,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum unitlessUnitEnum
   {
      /// <remarks/>
      Percent,
      /// <remarks/>
      Fraction,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum valueTypeEnum
   {
      /// <remarks/>
      Historical,
      /// <remarks/>
      Simulated,
      /// <remarks/>
      Rated,
      /// <remarks/>
      Measured,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum vegetationTypeEnum
   {
      /// <remarks/>
      Trees,
      /// <remarks/>
      Bushes,
      /// <remarks/>
      Plants,
      /// <remarks/>
      Grass,
      /// <remarks/>
      Moss,
      /// <remarks/>
      EvergreenTrees,
      /// <remarks/>
      EvergreenShrubs,
      /// <remarks/>
      DeciduousTrees,
      /// <remarks/>
      DeciduousShrubs,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum velocityUnitEnum
   {
      /// <remarks/>
      MetersPerSecond,
      /// <remarks/>
      MilesPerHour,
      /// <remarks/>
      Knots,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum windSpeedEnum
   {
      /// <remarks/>
      RatedWindSpeed,
      /// <remarks/>
      CutInWindSpeed,
      /// <remarks/>
      CutOutWindSpeed,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum versionEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("0.35")]
      Item035,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("0.36")]
      Item036,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("0.37")]
      Item037,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5.00")]
      Item500,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5.01")]
      Item501,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5.10")]
      Item510,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5.11")]
      Item511,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5.12")]
      Item512,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("6.00")]
      Item600,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("6.01")]
      Item601,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum viscosityUnitEnum
   {
      /// <remarks/>
      KgPerMSec,
      /// <remarks/>
      PoundPerFootSec,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum viscosityFofTUnitEnum
   {
      /// <remarks/>
      KgPerMSecK,
      /// <remarks/>
      PoundPerFootSecF,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum volumeUnitEnum
   {
      /// <remarks/>
      CubicKilometers,
      /// <remarks/>
      CubicMeters,
      /// <remarks/>
      CubicCentimeters,
      /// <remarks/>
      CubicMillimeters,
      /// <remarks/>
      CubicMiles,
      /// <remarks/>
      CubicYards,
      /// <remarks/>
      CubicFeet,
      /// <remarks/>
      CubicInches,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum wallASHRAEGroupEnum
   {
      /// <remarks/>
      A,
      /// <remarks/>
      B,
      /// <remarks/>
      C,
      /// <remarks/>
      D,
      /// <remarks/>
      E,
      /// <remarks/>
      F,
      /// <remarks/>
      G,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum wallColorEnum
   {
      /// <remarks/>
      Dark,
      /// <remarks/>
      Medium,
      /// <remarks/>
      Light,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum wallCTSTypeEnum
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("1")]
      Item1,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("2")]
      Item2,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("3")]
      Item3,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("4")]
      Item4,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("5")]
      Item5,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("6")]
      Item6,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("7")]
      Item7,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("8")]
      Item8,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("9")]
      Item9,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("10")]
      Item10,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("11")]
      Item11,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("12")]
      Item12,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("13")]
      Item13,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("14")]
      Item14,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("15")]
      Item15,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("16")]
      Item16,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("17")]
      Item17,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("18")]
      Item18,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("19")]
      Item19,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("20")]
      Item20,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("21")]
      Item21,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("22")]
      Item22,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("23")]
      Item23,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("24")]
      Item24,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("25")]
      Item25,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("26")]
      Item26,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("27")]
      Item27,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("28")]
      Item28,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("29")]
      Item29,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("30")]
      Item30,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("31")]
      Item31,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("32")]
      Item32,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("33")]
      Item33,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("34")]
      Item34,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("35")]
      Item35,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum surfaceReferenceLocationEnum
   {
      /// <remarks/>
      Centerline,
      /// <remarks/>
      InteriorSurface,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum wallGroupManualJEnum
   {
      /// <remarks/>
      A,
      /// <remarks/>
      B,
      /// <remarks/>
      C,
      /// <remarks/>
      D,
      /// <remarks/>
      E,
      /// <remarks/>
      F,
      /// <remarks/>
      G,
      /// <remarks/>
      H,
      /// <remarks/>
      I,
      /// <remarks/>
      J,
      /// <remarks/>
      K,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum waterUseUnitEnum
   {
      /// <remarks/>
      CubicMeters,
      /// <remarks/>
      Gallons,
      /// <remarks/>
      Tons,
      /// <remarks/>
      Kilograms,
      /// <remarks/>
      Liters,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public enum weightUnitEnum
   {
      /// <remarks/>
      Pounds,
      /// <remarks/>
      Kilograms,
      /// <remarks/>
      Tons,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class gbXML
   {
      private object[] itemsField;
      private string idField;
      private gbXMLEngine engineField;
      private bool engineFieldSpecified;
      private temperatureUnitEnum temperatureUnitField;
      private lengthUnitEnum lengthUnitField;
      private areaUnitEnum areaUnitField;
      private volumeUnitEnum volumeUnitField;
      private bool useSIUnitsForResultsField;
      private versionEnum versionField;
      private surfaceReferenceLocationEnum surfaceReferenceLocationField;
      private bool surfaceReferenceLocationFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AirLoop", typeof(AirLoop))]
      [System.Xml.Serialization.XmlElementAttribute("Campus", typeof(Campus))]
      [System.Xml.Serialization.XmlElementAttribute("Construction", typeof(Construction))]
      [System.Xml.Serialization.XmlElementAttribute("DaySchedule", typeof(DaySchedule))]
      [System.Xml.Serialization.XmlElementAttribute("DocumentHistory", typeof(DocumentHistory))]
      [System.Xml.Serialization.XmlElementAttribute("ExtEquip", typeof(ExtEquip))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoop", typeof(HydronicLoop))]
      [System.Xml.Serialization.XmlElementAttribute("IntEquip", typeof(IntEquip))]
      [System.Xml.Serialization.XmlElementAttribute("Layer", typeof(Layer))]
      [System.Xml.Serialization.XmlElementAttribute("LightingControl", typeof(LightingControl))]
      [System.Xml.Serialization.XmlElementAttribute("LightingSystem", typeof(LightingSystem))]
      [System.Xml.Serialization.XmlElementAttribute("Material", typeof(Material))]
      [System.Xml.Serialization.XmlElementAttribute("Meter", typeof(Meter))]
      [System.Xml.Serialization.XmlElementAttribute("Results", typeof(Results))]
      [System.Xml.Serialization.XmlElementAttribute("Schedule", typeof(Schedule))]
      [System.Xml.Serialization.XmlElementAttribute("SimulationParameters", typeof(SimulationParameters))]
      [System.Xml.Serialization.XmlElementAttribute("Weather", typeof(Weather))]
      [System.Xml.Serialization.XmlElementAttribute("WeekSchedule", typeof(WeekSchedule))]
      [System.Xml.Serialization.XmlElementAttribute("WindowType", typeof(WindowType))]
      [System.Xml.Serialization.XmlElementAttribute("Zone", typeof(Zone))]
      [System.Xml.Serialization.XmlElementAttribute("aecXML", typeof(object))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public gbXMLEngine engine
      {
         get
         {
            return this.engineField;
         }
         set
         {
            this.engineField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool engineSpecified
      {
         get
         {
            return this.engineFieldSpecified;
         }
         set
         {
            this.engineFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum temperatureUnit
      {
         get
         {
            return this.temperatureUnitField;
         }
         set
         {
            this.temperatureUnitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum lengthUnit
      {
         get
         {
            return this.lengthUnitField;
         }
         set
         {
            this.lengthUnitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public areaUnitEnum areaUnit
      {
         get
         {
            return this.areaUnitField;
         }
         set
         {
            this.areaUnitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public volumeUnitEnum volumeUnit
      {
         get
         {
            return this.volumeUnitField;
         }
         set
         {
            this.volumeUnitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool useSIUnitsForResults
      {
         get
         {
            return this.useSIUnitsForResultsField;
         }
         set
         {
            this.useSIUnitsForResultsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public versionEnum version
      {
         get
         {
            return this.versionField;
         }
         set
         {
            this.versionField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public surfaceReferenceLocationEnum SurfaceReferenceLocation
      {
         get
         {
            return this.surfaceReferenceLocationField;
         }
         set
         {
            this.surfaceReferenceLocationField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool SurfaceReferenceLocationSpecified
      {
         get
         {
            return this.surfaceReferenceLocationFieldSpecified;
         }
         set
         {
            this.surfaceReferenceLocationFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AirLoop
   {
      private object[] itemsField;
      private ItemsChoiceType28[] itemsElementNameField;
      private string idField;
      private string controlZoneIdRefField;
      private systemTypeEnum systemTypeField;
      private bool systemTypeFieldSpecified;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AirLoopEquipment", typeof(AirLoopEquipment))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PressureControl", typeof(PressureControl))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("TemperatureControl", typeof(TemperatureControl))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType28[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string controlZoneIdRef
      {
         get
         {
            return this.controlZoneIdRefField;
         }
         set
         {
            this.controlZoneIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public systemTypeEnum systemType
      {
         get
         {
            return this.systemTypeField;
         }
         set
         {
            this.systemTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool systemTypeSpecified
      {
         get
         {
            return this.systemTypeFieldSpecified;
         }
         set
         {
            this.systemTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AirLoopEquipment
   {
      private object[] itemsField;
      private ItemsChoiceType27[] itemsElementNameField;
      private string idField;
      private equipmentTypeEnum equipmentTypeField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AirStreamFraction", typeof(AirStreamFraction))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Capacity", typeof(Capacity))]
      [System.Xml.Serialization.XmlElementAttribute("Control", typeof(Control))]
      [System.Xml.Serialization.XmlElementAttribute("CoolingCoilSetpointResetType", typeof(CoolingCoilSetpointResetType))]
      [System.Xml.Serialization.XmlElementAttribute("CoolingCoilType", typeof(CoolingCoilType))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("CyclingRateMax", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("DamperHeatingAction", typeof(DamperHeatingAction))]
      [System.Xml.Serialization.XmlElementAttribute("DeltaP", typeof(DeltaP))]
      [System.Xml.Serialization.XmlElementAttribute("DeltaT", typeof(DeltaT))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("EconomizerLockout", typeof(EconomizerLockout))]
      [System.Xml.Serialization.XmlElementAttribute("Efficiency", typeof(Efficiency))]
      [System.Xml.Serialization.XmlElementAttribute("Energy", typeof(Energy))]
      [System.Xml.Serialization.XmlElementAttribute("Enthalpy", typeof(Enthalpy))]
      [System.Xml.Serialization.XmlElementAttribute("FlowType", typeof(FlowType))]
      [System.Xml.Serialization.XmlElementAttribute("FractionOnCyclePowerUse", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("GasPreheatCoilEfficiency", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("GasPreheatCoilParasiticElectricLoad", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("HeatPumpDefrostControl", typeof(HeatPumpDefrostControl))]
      [System.Xml.Serialization.XmlElementAttribute("HeatPumpDefrostStrategy", typeof(HeatPumpDefrostStrategy))]
      [System.Xml.Serialization.XmlElementAttribute("HeatPumpFanDelayTime", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("HeatPumpTimeConstant", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("HeatRecoveryType", typeof(HeatRecoveryType))]
      [System.Xml.Serialization.XmlElementAttribute("HeatingCoilSetpointResetType", typeof(HeatingCoilSetpointResetType))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoopId", typeof(HydronicLoopId))]
      [System.Xml.Serialization.XmlElementAttribute("LatentHeatRecoveryEffectiveness", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Life", typeof(Life))]
      [System.Xml.Serialization.XmlElementAttribute("Manufacturer", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("MaxRelativeHumidity", typeof(MaxRelativeHumidity))]
      [System.Xml.Serialization.XmlElementAttribute("MaximumFlow", typeof(MaximumFlow))]
      [System.Xml.Serialization.XmlElementAttribute("MaximumFlowFractionDuringReheat", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("MinFlow", typeof(MinFlow))]
      [System.Xml.Serialization.XmlElementAttribute("MinRelativeHumidity", typeof(MinRelativeHumidity))]
      [System.Xml.Serialization.XmlElementAttribute("Model", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("MotorInAirstream", typeof(bool))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("NightCycleControl", typeof(NightCycleControl))]
      [System.Xml.Serialization.XmlElementAttribute("OperationSchedule", typeof(OperationSchedule))]
      [System.Xml.Serialization.XmlElementAttribute("ParallelFanOnFlowFraction", typeof(ParallelFanOnFlowFraction))]
      [System.Xml.Serialization.XmlElementAttribute("Performance", typeof(Performance))]
      [System.Xml.Serialization.XmlElementAttribute("Power", typeof(Power))]
      [System.Xml.Serialization.XmlElementAttribute("PreheatCoilType", typeof(PreheatCoilType))]
      [System.Xml.Serialization.XmlElementAttribute("RatedFlow", typeof(RatedFlow))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("RefrigerantType", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ResetTemperature", typeof(ResetTemperature))]
      [System.Xml.Serialization.XmlElementAttribute("SensibleHeatRecoveryEffectiveness", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("SupplementalGasHeatingCoilEfficiency", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("SupplementalGasHeatingCoilParasiticElectricLoad", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("SupplementalHeatingCoilCapacity", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("SupplementalHeatingCoilType", typeof(SupplementalHeatingCoilType))]
      [System.Xml.Serialization.XmlElementAttribute("Temp", typeof(Temp))]
      [System.Xml.Serialization.XmlElementAttribute("WaterLoss", typeof(WaterLoss))]
      [System.Xml.Serialization.XmlElementAttribute("Weight", typeof(Weight))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType27[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public equipmentTypeEnum equipmentType
      {
         get
         {
            return this.equipmentTypeField;
         }
         set
         {
            this.equipmentTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AirStreamFraction
   {
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CADObjectId
   {
      private string programIdRefField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programIdRef
      {
         get
         {
            return this.programIdRefField;
         }
         set
         {
            this.programIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Capacity
   {
      private capacityUnitEnum unitField;
      private capacityTypeEnum capacityTypeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public capacityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public capacityTypeEnum capacityType
      {
         get
         {
            return this.capacityTypeField;
         }
         set
         {
            this.capacityTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Control
   {
      private controlTypeEnum controlTypeField;
      private bool controlTypeFieldSpecified;
      private stageTypeEnum stagesField;
      private bool stagesFieldSpecified;
      private float minPowerRatioField;
      private bool minPowerRatioFieldSpecified;
      private operationTypeEnum operationTypeField;
      private bool operationTypeFieldSpecified;
      private string performanceIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public controlTypeEnum controlType
      {
         get
         {
            return this.controlTypeField;
         }
         set
         {
            this.controlTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool controlTypeSpecified
      {
         get
         {
            return this.controlTypeFieldSpecified;
         }
         set
         {
            this.controlTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public stageTypeEnum stages
      {
         get
         {
            return this.stagesField;
         }
         set
         {
            this.stagesField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool stagesSpecified
      {
         get
         {
            return this.stagesFieldSpecified;
         }
         set
         {
            this.stagesFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public float minPowerRatio
      {
         get
         {
            return this.minPowerRatioField;
         }
         set
         {
            this.minPowerRatioField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool minPowerRatioSpecified
      {
         get
         {
            return this.minPowerRatioFieldSpecified;
         }
         set
         {
            this.minPowerRatioFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public operationTypeEnum operationType
      {
         get
         {
            return this.operationTypeField;
         }
         set
         {
            this.operationTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool operationTypeSpecified
      {
         get
         {
            return this.operationTypeFieldSpecified;
         }
         set
         {
            this.operationTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string performanceIdRef
      {
         get
         {
            return this.performanceIdRefField;
         }
         set
         {
            this.performanceIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CoolingCoilSetpointResetType
   {
      private coolingCoilSetpointResetTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public coolingCoilSetpointResetTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CoolingCoilType
   {
      private coolingCoilTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public coolingCoilTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Cost
   {
      private object[] itemsField;
      private costTypeEnum costTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CostValue", typeof(CostValue))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public costTypeEnum costType
      {
         get
         {
            return this.costTypeField;
         }
         set
         {
            this.costTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CostValue
   {
      private currencyTypeEnum currencyField;
      private bool currencyFieldSpecified;
      private string unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public currencyTypeEnum currency
      {
         get
         {
            return this.currencyField;
         }
         set
         {
            this.currencyField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool currencySpecified
      {
         get
         {
            return this.currencyFieldSpecified;
         }
         set
         {
            this.currencyFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DamperHeatingAction
   {
      private damperHeatingActionEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public damperHeatingActionEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DeltaP
   {
      private deltaPUnitEnum unitField;
      private loopTypeEnum hydronicLoopTypeField;
      private bool hydronicLoopTypeFieldSpecified;
      private string hydronicLoopIdRefField;
      private conditioningTypeEnum conditioningTypeField;
      private bool conditioningTypeFieldSpecified;
      private string performanceIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public deltaPUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loopTypeEnum hydronicLoopType
      {
         get
         {
            return this.hydronicLoopTypeField;
         }
         set
         {
            this.hydronicLoopTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool hydronicLoopTypeSpecified
      {
         get
         {
            return this.hydronicLoopTypeFieldSpecified;
         }
         set
         {
            this.hydronicLoopTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conditioningTypeEnum conditioningType
      {
         get
         {
            return this.conditioningTypeField;
         }
         set
         {
            this.conditioningTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool conditioningTypeSpecified
      {
         get
         {
            return this.conditioningTypeFieldSpecified;
         }
         set
         {
            this.conditioningTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string performanceId
      {
         get
         {
            return this.performanceIdField;
         }
         set
         {
            this.performanceIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DeltaT
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private conditioningTypeEnum conditioningTypeField;
      private bool conditioningTypeFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conditioningTypeEnum conditioningType
      {
         get
         {
            return this.conditioningTypeField;
         }
         set
         {
            this.conditioningTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool conditioningTypeSpecified
      {
         get
         {
            return this.conditioningTypeFieldSpecified;
         }
         set
         {
            this.conditioningTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class EconomizerLockout
   {
      private economizerLockoutEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public economizerLockoutEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Efficiency
   {
      private standardsTypeEnum standardsTypeField;
      private bool standardsTypeFieldSpecified;
      private efficiencyTypeEnum efficiencyTypeField;
      private conditioningTypeEnum operationTypeField;
      private bool operationTypeFieldSpecified;
      private string performanceIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public standardsTypeEnum standardsType
      {
         get
         {
            return this.standardsTypeField;
         }
         set
         {
            this.standardsTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool standardsTypeSpecified
      {
         get
         {
            return this.standardsTypeFieldSpecified;
         }
         set
         {
            this.standardsTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public efficiencyTypeEnum efficiencyType
      {
         get
         {
            return this.efficiencyTypeField;
         }
         set
         {
            this.efficiencyTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conditioningTypeEnum operationType
      {
         get
         {
            return this.operationTypeField;
         }
         set
         {
            this.operationTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool operationTypeSpecified
      {
         get
         {
            return this.operationTypeFieldSpecified;
         }
         set
         {
            this.operationTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string performanceId
      {
         get
         {
            return this.performanceIdField;
         }
         set
         {
            this.performanceIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Energy
   {
      private energyUnitEnum unitField;
      private valueTypeEnum valueTypeField;
      private timePeriodEnum timePeriodField;
      private resourceTypeEnum resourceTypeField;
      private string meterIdRefField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public energyUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public valueTypeEnum valueType
      {
         get
         {
            return this.valueTypeField;
         }
         set
         {
            this.valueTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public timePeriodEnum timePeriod
      {
         get
         {
            return this.timePeriodField;
         }
         set
         {
            this.timePeriodField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resourceTypeEnum resourceType
      {
         get
         {
            return this.resourceTypeField;
         }
         set
         {
            this.resourceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string meterIdRef
      {
         get
         {
            return this.meterIdRefField;
         }
         set
         {
            this.meterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Enthalpy
   {
      private enthalpyUnitEnum unitField;
      private enthalpyTypeEnum enthalpyTypeField;
      private bool enthalpyTypeFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public enthalpyUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public enthalpyTypeEnum enthalpyType
      {
         get
         {
            return this.enthalpyTypeField;
         }
         set
         {
            this.enthalpyTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool enthalpyTypeSpecified
      {
         get
         {
            return this.enthalpyTypeFieldSpecified;
         }
         set
         {
            this.enthalpyTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FlowType
   {
      private flowTypeEnum flowTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowTypeEnum flowType
      {
         get
         {
            return this.flowTypeField;
         }
         set
         {
            this.flowTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class GeneralGeometry
   {
      private System.Xml.XmlElement[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      public System.Xml.XmlElement[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HeatPumpDefrostControl
   {
      private defrostControlEnum defrostControlTypeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public defrostControlEnum defrostControlType
      {
         get
         {
            return this.defrostControlTypeField;
         }
         set
         {
            this.defrostControlTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HeatPumpDefrostStrategy
   {
      private defrostStrategyEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public defrostStrategyEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HeatRecoveryType
   {
      private heatRecoveryTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public heatRecoveryTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HeatingCoilSetpointResetType
   {
      private heatingCoilSetpointResetTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public heatingCoilSetpointResetTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HydronicLoopId
   {
      private string hydronicLoopIdRefField;
      private loopTypeEnum hydronicLoopTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loopTypeEnum hydronicLoopType
      {
         get
         {
            return this.hydronicLoopTypeField;
         }
         set
         {
            this.hydronicLoopTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Life
   {
      private lifeUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lifeUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MaxRelativeHumidity
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MaximumFlow
   {
      private flowUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinFlow
   {
      private string unitField;
      private string hydronicLoopIdRefField;
      private loopTypeEnum hydronicLoopTypeField;
      private bool hydronicLoopTypeFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loopTypeEnum hydronicLoopType
      {
         get
         {
            return this.hydronicLoopTypeField;
         }
         set
         {
            this.hydronicLoopTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool hydronicLoopTypeSpecified
      {
         get
         {
            return this.hydronicLoopTypeFieldSpecified;
         }
         set
         {
            this.hydronicLoopTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinRelativeHumidity
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class NightCycleControl
   {
      private nightCycleControlEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public nightCycleControlEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class OperationSchedule
   {
      private OperationRange[] itemsField;
      private string scheduleIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("OperationRange")]
      public OperationRange[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class OperationRange
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("HighValue", typeof(HighValue))]
      [System.Xml.Serialization.XmlElementAttribute("LowValue", typeof(LowValue))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HighValue
   {
      private conditioningUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conditioningUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LowValue
   {
      private conditioningUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conditioningUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ParallelFanOnFlowFraction
   {
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Performance
   {
      private Equation[] itemsField;
      private ItemsChoiceType26[] itemsElementNameField;
      private string idField;
      private string performanceTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Equation", typeof(Equation))]
      [System.Xml.Serialization.XmlElementAttribute("PointData", typeof(PointData))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public Equation[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType26[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string performanceType
      {
         get
         {
            return this.performanceTypeField;
         }
         set
         {
            this.performanceTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Equation
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DependentVariable", typeof(DependentVariable))]
      [System.Xml.Serialization.XmlElementAttribute("Expression", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("IndependentVariable", typeof(IndependentVariable))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DependentVariable
   {
      private string[] itemsField;
      private ItemsChoiceType24[] itemsElementNameField;
      private string unitField;
      private string dataTypeField;
      private decimal minValueField;
      private bool minValueFieldSpecified;
      private decimal maxValueField;
      private bool maxValueFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType24[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string dataType
      {
         get
         {
            return this.dataTypeField;
         }
         set
         {
            this.dataTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal minValue
      {
         get
         {
            return this.minValueField;
         }
         set
         {
            this.minValueField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool minValueSpecified
      {
         get
         {
            return this.minValueFieldSpecified;
         }
         set
         {
            this.minValueFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal maxValue
      {
         get
         {
            return this.maxValueField;
         }
         set
         {
            this.maxValueField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool maxValueSpecified
      {
         get
         {
            return this.maxValueFieldSpecified;
         }
         set
         {
            this.maxValueFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType24
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class IndependentVariable
   {
      private string[] itemsField;
      private ItemsChoiceType23[] itemsElementNameField;
      private string unitField;
      private string dataTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType23[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string dataType
      {
         get
         {
            return this.dataTypeField;
         }
         set
         {
            this.dataTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType23
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PointData
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Data", typeof(Data))]
      [System.Xml.Serialization.XmlElementAttribute("DependentVariable", typeof(DependentVariable))]
      [System.Xml.Serialization.XmlElementAttribute("IndependentVariable", typeof(IndependentVariable))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Data
   {
      private decimal[] itemsField;
      private ItemsChoiceType25[] itemsElementNameField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DependentValue", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("IndependentValue", typeof(decimal))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public decimal[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType25[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType25
   {
      /// <remarks/>
      DependentValue,
      /// <remarks/>
      IndependentValue,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType26
   {
      /// <remarks/>
      Equation,
      /// <remarks/>
      PointData,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Power
   {
      private powerUnitEnum unitField;
      private powerTypeEnum powerTypeField;
      private powerUseTypeEnum useTypeField;
      private string meterIdRefField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerTypeEnum powerType
      {
         get
         {
            return this.powerTypeField;
         }
         set
         {
            this.powerTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerUseTypeEnum useType
      {
         get
         {
            return this.useTypeField;
         }
         set
         {
            this.useTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string meterIdRef
      {
         get
         {
            return this.meterIdRefField;
         }
         set
         {
            this.meterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PreheatCoilType
   {
      private preheatCoilTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public preheatCoilTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class RatedFlow
   {
      private flowUnitEnum unitField;
      private string hydronicLoopIdRefField;
      private loopTypeEnum hydronicLoopTypeField;
      private bool hydronicLoopTypeFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loopTypeEnum hydronicLoopType
      {
         get
         {
            return this.hydronicLoopTypeField;
         }
         set
         {
            this.hydronicLoopTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool hydronicLoopTypeSpecified
      {
         get
         {
            return this.hydronicLoopTypeFieldSpecified;
         }
         set
         {
            this.hydronicLoopTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ResetTemperature
   {
      private temperatureUnitEnum unitField;
      private resetTemperatureTypeEnum typeField;
      private string resetSchedIdRefField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resetTemperatureTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string resetSchedIdRef
      {
         get
         {
            return this.resetSchedIdRefField;
         }
         set
         {
            this.resetSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ShellGeometry
   {
      private object[] itemsField;
      private ItemsChoiceType[] itemsElementNameField;
      private string idField;
      private lengthUnitEnum unitField;
      public ShellGeometry()
      {
         this.unitField = lengthUnitEnum.Meters;
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ClosedShell", typeof(ClosedShell))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(lengthUnitEnum.Meters)]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ClosedShell
   {
      private PolyLoop[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("PolyLoop")]
      public PolyLoop[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PolyLoop
   {
      private CartesianPoint[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CartesianPoint")]
      public CartesianPoint[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CartesianPoint
   {
      private Coordinate[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Coordinate")]
      public Coordinate[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Coordinate
   {
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType
   {
      /// <remarks/>
      ClosedShell,
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SupplementalHeatingCoilType
   {
      private supplementalHeatingCoilTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public supplementalHeatingCoilTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Temp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private tempTypeEnum tempTypeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public tempTypeEnum tempType
      {
         get
         {
            return this.tempTypeField;
         }
         set
         {
            this.tempTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WaterLoss
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Weight
   {
      private weightUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public weightUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType27
   {
      /// <remarks/>
      AirStreamFraction,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Capacity,
      /// <remarks/>
      Control,
      /// <remarks/>
      CoolingCoilSetpointResetType,
      /// <remarks/>
      CoolingCoilType,
      /// <remarks/>
      Cost,
      /// <remarks/>
      CyclingRateMax,
      /// <remarks/>
      DamperHeatingAction,
      /// <remarks/>
      DeltaP,
      /// <remarks/>
      DeltaT,
      /// <remarks/>
      Description,
      /// <remarks/>
      EconomizerLockout,
      /// <remarks/>
      Efficiency,
      /// <remarks/>
      Energy,
      /// <remarks/>
      Enthalpy,
      /// <remarks/>
      FlowType,
      /// <remarks/>
      FractionOnCyclePowerUse,
      /// <remarks/>
      GasPreheatCoilEfficiency,
      /// <remarks/>
      GasPreheatCoilParasiticElectricLoad,
      /// <remarks/>
      GeneralGeometry,
      /// <remarks/>
      HeatPumpDefrostControl,
      /// <remarks/>
      HeatPumpDefrostStrategy,
      /// <remarks/>
      HeatPumpFanDelayTime,
      /// <remarks/>
      HeatPumpTimeConstant,
      /// <remarks/>
      HeatRecoveryType,
      /// <remarks/>
      HeatingCoilSetpointResetType,
      /// <remarks/>
      HydronicLoopId,
      /// <remarks/>
      LatentHeatRecoveryEffectiveness,
      /// <remarks/>
      Life,
      /// <remarks/>
      Manufacturer,
      /// <remarks/>
      MaxRelativeHumidity,
      /// <remarks/>
      MaximumFlow,
      /// <remarks/>
      MaximumFlowFractionDuringReheat,
      /// <remarks/>
      MinFlow,
      /// <remarks/>
      MinRelativeHumidity,
      /// <remarks/>
      Model,
      /// <remarks/>
      MotorInAirstream,
      /// <remarks/>
      Name,
      /// <remarks/>
      NightCycleControl,
      /// <remarks/>
      OperationSchedule,
      /// <remarks/>
      ParallelFanOnFlowFraction,
      /// <remarks/>
      Performance,
      /// <remarks/>
      Power,
      /// <remarks/>
      PreheatCoilType,
      /// <remarks/>
      RatedFlow,
      /// <remarks/>
      Reference,
      /// <remarks/>
      RefrigerantType,
      /// <remarks/>
      ResetTemperature,
      /// <remarks/>
      SensibleHeatRecoveryEffectiveness,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      SupplementalGasHeatingCoilEfficiency,
      /// <remarks/>
      SupplementalGasHeatingCoilParasiticElectricLoad,
      /// <remarks/>
      SupplementalHeatingCoilCapacity,
      /// <remarks/>
      SupplementalHeatingCoilType,
      /// <remarks/>
      Temp,
      /// <remarks/>
      WaterLoss,
      /// <remarks/>
      Weight,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PressureControl
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DesignPressure", typeof(DesignPressure))]
      [System.Xml.Serialization.XmlElementAttribute("MaxPressure", typeof(MaxPressure))]
      [System.Xml.Serialization.XmlElementAttribute("MinPressure", typeof(MinPressure))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DesignPressure
   {
      private pressureUnitEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public pressureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MaxPressure
   {
      private pressureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public pressureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinPressure
   {
      private pressureUnitEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public pressureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class TemperatureControl
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DesignTemp", typeof(DesignTemp))]
      [System.Xml.Serialization.XmlElementAttribute("MaxTemp", typeof(MaxTemp))]
      [System.Xml.Serialization.XmlElementAttribute("MinTemp", typeof(MinTemp))]
      [System.Xml.Serialization.XmlElementAttribute("ResetTemperature", typeof(ResetTemperature))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DesignTemp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MaxTemp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinTemp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType28
   {
      /// <remarks/>
      AirLoopEquipment,
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      PressureControl,
      /// <remarks/>
      Reference,
      /// <remarks/>
      TemperatureControl,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Campus
   {
      private object[] itemsField;
      private ItemsChoiceType8[] itemsElementNameField;
      private string idField;
      private string designHeatWeathIdRefField;
      private string designCoolWeathIdRefField;
      private string ifcGUIDField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AltEnergySource", typeof(AltEnergySource))]
      [System.Xml.Serialization.XmlElementAttribute("Building", typeof(Building))]
      [System.Xml.Serialization.XmlElementAttribute("DaylightSavings", typeof(bool))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ExtEquipId", typeof(ExtEquipId))]
      [System.Xml.Serialization.XmlElementAttribute("Life", typeof(Life))]
      [System.Xml.Serialization.XmlElementAttribute("LightControlId", typeof(LightControlId))]
      [System.Xml.Serialization.XmlElementAttribute("Lighting", typeof(Lighting))]
      [System.Xml.Serialization.XmlElementAttribute("Location", typeof(Location))]
      [System.Xml.Serialization.XmlElementAttribute("MeterId", typeof(MeterId))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("Surface", typeof(Surface))]
      [System.Xml.Serialization.XmlElementAttribute("Transportation", typeof(Transportation))]
      [System.Xml.Serialization.XmlElementAttribute("Vegetation", typeof(Vegetation))]
      [System.Xml.Serialization.XmlElementAttribute("YearModeled", typeof(YearModeled))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType8[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string designHeatWeathIdRef
      {
         get
         {
            return this.designHeatWeathIdRefField;
         }
         set
         {
            this.designHeatWeathIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string designCoolWeathIdRef
      {
         get
         {
            return this.designCoolWeathIdRefField;
         }
         set
         {
            this.designCoolWeathIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AltEnergySource
   {
      private MeterId[] itemsField;
      private string idField;
      private AltEnergySourceAltEnergyType altEnergyTypeField;
      private resourceTypeEnum resourceTypeField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("MeterId")]
      public MeterId[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public AltEnergySourceAltEnergyType altEnergyType
      {
         get
         {
            return this.altEnergyTypeField;
         }
         set
         {
            this.altEnergyTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resourceTypeEnum resourceType
      {
         get
         {
            return this.resourceTypeField;
         }
         set
         {
            this.resourceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MeterId
   {
      private string meterIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string meterIdRef
      {
         get
         {
            return this.meterIdRefField;
         }
         set
         {
            this.meterIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   public enum AltEnergySourceAltEnergyType
   {
      /// <remarks/>
      Solar,
      /// <remarks/>
      Wind,
      /// <remarks/>
      Geothermal,
      /// <remarks/>
      HeatRecovery,
      /// <remarks/>
      NaturalGas,
      /// <remarks/>
      Electrical,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Building
   {
      private object[] itemsField;
      private ItemsChoiceType3[] itemsElementNameField;
      private string idField;
      private buildingTypeEnum buildingTypeField;
      private string ifcGUIDField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Area", typeof(Area))]
      [System.Xml.Serialization.XmlElementAttribute("AverageNumberOfFloors", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("BuildingStorey", typeof(BuildingStorey))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("InfiltrationFlow", typeof(InfiltrationFlow))]
      [System.Xml.Serialization.XmlElementAttribute("IntEquipId", typeof(IntEquipId))]
      [System.Xml.Serialization.XmlElementAttribute("Lighting", typeof(Lighting))]
      [System.Xml.Serialization.XmlElementAttribute("MeterId", typeof(MeterId))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PeakDomesticHotWaterFlow", typeof(PeakDomesticHotWaterFlow))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("Space", typeof(Space))]
      [System.Xml.Serialization.XmlElementAttribute("SpaceBoundary", typeof(SpaceBoundary))]
      [System.Xml.Serialization.XmlElementAttribute("StreetAddress", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType3[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public buildingTypeEnum buildingType
      {
         get
         {
            return this.buildingTypeField;
         }
         set
         {
            this.buildingTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Area
   {
      private areaUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public areaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class BuildingStorey
   {
      private object[] itemsField;
      private string idField;
      private string ifcGUIDField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Level", typeof(Level))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PlanarGeometry", typeof(PlanarGeometry))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Level
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PlanarGeometry
   {
      private PolyLoop[] itemsField;
      private string idField;
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("PolyLoop")]
      public PolyLoop[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class InfiltrationFlow
   {
      private object[] itemsField;
      private infiltrationTypeEnum typeField;
      private bool typeFieldSpecified;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("BlowerDoorValue", typeof(BlowerDoorValue))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public infiltrationTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool typeSpecified
      {
         get
         {
            return this.typeFieldSpecified;
         }
         set
         {
            this.typeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class BlowerDoorValue
   {
      private blowerDoorUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public blowerDoorUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class IntEquipId
   {
      private string intEquipIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string intEquipIdRef
      {
         get
         {
            return this.intEquipIdRefField;
         }
         set
         {
            this.intEquipIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Lighting
   {
      private object[] itemsField;
      private string idField;
      private string lightingSystemIdRefField;
      private string lightingControlIdRefField;
      private string meterIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CoefficientOfUtilization", typeof(CoefficientOfUtilization))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("PhotometryOrientation", typeof(PhotometryOrientation))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string lightingSystemIdRef
      {
         get
         {
            return this.lightingSystemIdRefField;
         }
         set
         {
            this.lightingSystemIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string lightingControlIdRef
      {
         get
         {
            return this.lightingControlIdRefField;
         }
         set
         {
            this.lightingControlIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string meterIdRef
      {
         get
         {
            return this.meterIdRefField;
         }
         set
         {
            this.meterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CoefficientOfUtilization
   {
      private decimal wallReflectanceField;
      private bool wallReflectanceFieldSpecified;
      private decimal ceilingCavityReflectanceField;
      private bool ceilingCavityReflectanceFieldSpecified;
      private decimal floorReflectanceField;
      private bool floorReflectanceFieldSpecified;
      private decimal roomCavityRatioField;
      private bool roomCavityRatioFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal wallReflectance
      {
         get
         {
            return this.wallReflectanceField;
         }
         set
         {
            this.wallReflectanceField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool wallReflectanceSpecified
      {
         get
         {
            return this.wallReflectanceFieldSpecified;
         }
         set
         {
            this.wallReflectanceFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal ceilingCavityReflectance
      {
         get
         {
            return this.ceilingCavityReflectanceField;
         }
         set
         {
            this.ceilingCavityReflectanceField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool ceilingCavityReflectanceSpecified
      {
         get
         {
            return this.ceilingCavityReflectanceFieldSpecified;
         }
         set
         {
            this.ceilingCavityReflectanceFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal floorReflectance
      {
         get
         {
            return this.floorReflectanceField;
         }
         set
         {
            this.floorReflectanceField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool floorReflectanceSpecified
      {
         get
         {
            return this.floorReflectanceFieldSpecified;
         }
         set
         {
            this.floorReflectanceFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal roomCavityRatio
      {
         get
         {
            return this.roomCavityRatioField;
         }
         set
         {
            this.roomCavityRatioField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool roomCavityRatioSpecified
      {
         get
         {
            return this.roomCavityRatioFieldSpecified;
         }
         set
         {
            this.roomCavityRatioFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PhotometryOrientation
   {
      private CartesianPoint[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CartesianPoint")]
      public CartesianPoint[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PeakDomesticHotWaterFlow
   {
      private flowUnitEnum unitField;
      private string hydronicLoopIdRefField;
      private string waterUseScheduleIdRefField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterUseScheduleIdRef
      {
         get
         {
            return this.waterUseScheduleIdRefField;
         }
         set
         {
            this.waterUseScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Space
   {
      private object[] itemsField;
      private ItemsChoiceType2[] itemsElementNameField;
      private string idField;
      private spaceTypeEnum spaceTypeField;
      private bool spaceTypeFieldSpecified;
      private string zoneIdRefField;
      private string scheduleIdRefField;
      private string lightScheduleIdRefField;
      private string equipmentScheduleIdRefField;
      private string peopleScheduleIdRefField;
      private conditionTypeEnum conditionTypeField;
      private bool conditionTypeFieldSpecified;
      private string buildingStoreyIdRefField;
      private string ifcGUIDField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AirChangesPerHour", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("AirLoopEquipmentId", typeof(AirLoopEquipmentId))]
      [System.Xml.Serialization.XmlElementAttribute("AirLoopId", typeof(AirLoopId))]
      [System.Xml.Serialization.XmlElementAttribute("Area", typeof(Area))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("EquipPowerPerArea", typeof(EquipPowerPerArea))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoopEquipmentId", typeof(HydronicLoopEquipmentId))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoopId", typeof(HydronicLoopId))]
      [System.Xml.Serialization.XmlElementAttribute("InfiltrationFlow", typeof(InfiltrationFlow))]
      [System.Xml.Serialization.XmlElementAttribute("IntEquipId", typeof(IntEquipId))]
      [System.Xml.Serialization.XmlElementAttribute("LightPowerPerArea", typeof(LightPowerPerArea))]
      [System.Xml.Serialization.XmlElementAttribute("Lighting", typeof(Lighting))]
      [System.Xml.Serialization.XmlElementAttribute("LightingControl", typeof(LightingControl))]
      [System.Xml.Serialization.XmlElementAttribute("MeterId", typeof(MeterId))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PeopleHeatGain", typeof(PeopleHeatGain))]
      [System.Xml.Serialization.XmlElementAttribute("PeopleNumber", typeof(PeopleNumber))]
      [System.Xml.Serialization.XmlElementAttribute("PlanarGeometry", typeof(PlanarGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("SpaceBoundary", typeof(SpaceBoundary))]
      [System.Xml.Serialization.XmlElementAttribute("Temperature", typeof(Temperature))]
      [System.Xml.Serialization.XmlElementAttribute("TypeCode", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Volume", typeof(Volume))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType2[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public spaceTypeEnum spaceType
      {
         get
         {
            return this.spaceTypeField;
         }
         set
         {
            this.spaceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool spaceTypeSpecified
      {
         get
         {
            return this.spaceTypeFieldSpecified;
         }
         set
         {
            this.spaceTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string zoneIdRef
      {
         get
         {
            return this.zoneIdRefField;
         }
         set
         {
            this.zoneIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string lightScheduleIdRef
      {
         get
         {
            return this.lightScheduleIdRefField;
         }
         set
         {
            this.lightScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string equipmentScheduleIdRef
      {
         get
         {
            return this.equipmentScheduleIdRefField;
         }
         set
         {
            this.equipmentScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string peopleScheduleIdRef
      {
         get
         {
            return this.peopleScheduleIdRefField;
         }
         set
         {
            this.peopleScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conditionTypeEnum conditionType
      {
         get
         {
            return this.conditionTypeField;
         }
         set
         {
            this.conditionTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool conditionTypeSpecified
      {
         get
         {
            return this.conditionTypeFieldSpecified;
         }
         set
         {
            this.conditionTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string buildingStoreyIdRef
      {
         get
         {
            return this.buildingStoreyIdRefField;
         }
         set
         {
            this.buildingStoreyIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AirLoopEquipmentId
   {
      private string airLoopEquipIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string airLoopEquipIdRef
      {
         get
         {
            return this.airLoopEquipIdRefField;
         }
         set
         {
            this.airLoopEquipIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AirLoopId
   {
      private string airLoopIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string airLoopIdRef
      {
         get
         {
            return this.airLoopIdRefField;
         }
         set
         {
            this.airLoopIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class EquipPowerPerArea
   {
      private powerPerAreaUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerPerAreaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HydronicLoopEquipmentId
   {
      private string hydronicLoopEquipIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopEquipIdRef
      {
         get
         {
            return this.hydronicLoopEquipIdRefField;
         }
         set
         {
            this.hydronicLoopEquipIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LightPowerPerArea
   {
      private powerPerAreaUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerPerAreaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LightingControl
   {
      private object[] itemsField;
      private ItemsChoiceType1[] itemsElementNameField;
      private lightControlTypeEnum typeField;
      private string idField;
      private string lightingSystemIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CartesianPoint", typeof(CartesianPoint))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("Illuminance", typeof(Illuminance))]
      [System.Xml.Serialization.XmlElementAttribute("MinLightFrac", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("MinPowerFrac", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("PercentAreaDaylitControlled", typeof(PercentAreaDaylitControlled))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType1[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lightControlTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string lightingSystemIdRef
      {
         get
         {
            return this.lightingSystemIdRefField;
         }
         set
         {
            this.lightingSystemIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Illuminance
   {
      private illuminanceUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public illuminanceUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PercentAreaDaylitControlled
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType1
   {
      /// <remarks/>
      CartesianPoint,
      /// <remarks/>
      GeneralGeometry,
      /// <remarks/>
      Illuminance,
      /// <remarks/>
      MinLightFrac,
      /// <remarks/>
      MinPowerFrac,
      /// <remarks/>
      PercentAreaDaylitControlled,
      /// <remarks/>
      ShellGeometry,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PeopleHeatGain
   {
      private peopleHeatGainUnitEnum unitField;
      private peopleHeatGainTypeEnum heatGainTypeField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public peopleHeatGainUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public peopleHeatGainTypeEnum heatGainType
      {
         get
         {
            return this.heatGainTypeField;
         }
         set
         {
            this.heatGainTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PeopleNumber
   {
      private peopleNumberUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public peopleNumberUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SpaceBoundary
   {
      private PlanarGeometry itemField;
      private string ifcGUIDField;
      private bool isSecondLevelBoundaryField;
      private bool isSecondLevelBoundaryFieldSpecified;
      private string surfaceIdRefField;
      private string oppositeIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("PlanarGeometry")]
      public PlanarGeometry Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool isSecondLevelBoundary
      {
         get
         {
            return this.isSecondLevelBoundaryField;
         }
         set
         {
            this.isSecondLevelBoundaryField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool isSecondLevelBoundarySpecified
      {
         get
         {
            return this.isSecondLevelBoundaryFieldSpecified;
         }
         set
         {
            this.isSecondLevelBoundaryFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string surfaceIdRef
      {
         get
         {
            return this.surfaceIdRefField;
         }
         set
         {
            this.surfaceIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string oppositeIdRef
      {
         get
         {
            return this.oppositeIdRefField;
         }
         set
         {
            this.oppositeIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Temperature
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Volume
   {
      private volumeUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public volumeUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType2
   {
      /// <remarks/>
      AirChangesPerHour,
      /// <remarks/>
      AirLoopEquipmentId,
      /// <remarks/>
      AirLoopId,
      /// <remarks/>
      Area,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Description,
      /// <remarks/>
      EquipPowerPerArea,
      /// <remarks/>
      HydronicLoopEquipmentId,
      /// <remarks/>
      HydronicLoopId,
      /// <remarks/>
      InfiltrationFlow,
      /// <remarks/>
      IntEquipId,
      /// <remarks/>
      LightPowerPerArea,
      /// <remarks/>
      Lighting,
      /// <remarks/>
      LightingControl,
      /// <remarks/>
      MeterId,
      /// <remarks/>
      Name,
      /// <remarks/>
      PeopleHeatGain,
      /// <remarks/>
      PeopleNumber,
      /// <remarks/>
      PlanarGeometry,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      SpaceBoundary,
      /// <remarks/>
      Temperature,
      /// <remarks/>
      TypeCode,
      /// <remarks/>
      Volume,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType3
   {
      /// <remarks/>
      Area,
      /// <remarks/>
      AverageNumberOfFloors,
      /// <remarks/>
      BuildingStorey,
      /// <remarks/>
      Description,
      /// <remarks/>
      InfiltrationFlow,
      /// <remarks/>
      IntEquipId,
      /// <remarks/>
      Lighting,
      /// <remarks/>
      MeterId,
      /// <remarks/>
      Name,
      /// <remarks/>
      PeakDomesticHotWaterFlow,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      Space,
      /// <remarks/>
      SpaceBoundary,
      /// <remarks/>
      StreetAddress,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ExtEquipId
   {
      private string extEquipIdRefField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string extEquipIdRef
      {
         get
         {
            return this.extEquipIdRefField;
         }
         set
         {
            this.extEquipIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LightControlId
   {
      private string scheduleIdRefField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Location
   {
      private StationId stationIdField;
      private string nameField;
      private string descriptionField;
      private string zipcodeOrPostalCodeField;
      private decimal longitudeField;
      private bool longitudeFieldSpecified;
      private decimal latitudeField;
      private bool latitudeFieldSpecified;
      private Elevation elevationField;
      private double cADModelAzimuthField;
      private bool cADModelAzimuthFieldSpecified;
      /// <remarks/>
      public StationId StationId
      {
         get
         {
            return this.stationIdField;
         }
         set
         {
            this.stationIdField = value;
         }
      }
      /// <remarks/>
      public string Name
      {
         get
         {
            return this.nameField;
         }
         set
         {
            this.nameField = value;
         }
      }
      /// <remarks/>
      public string Description
      {
         get
         {
            return this.descriptionField;
         }
         set
         {
            this.descriptionField = value;
         }
      }
      /// <remarks/>
      public string ZipcodeOrPostalCode
      {
         get
         {
            return this.zipcodeOrPostalCodeField;
         }
         set
         {
            this.zipcodeOrPostalCodeField = value;
         }
      }
      /// <remarks/>
      public decimal Longitude
      {
         get
         {
            return this.longitudeField;
         }
         set
         {
            this.longitudeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool LongitudeSpecified
      {
         get
         {
            return this.longitudeFieldSpecified;
         }
         set
         {
            this.longitudeFieldSpecified = value;
         }
      }
      /// <remarks/>
      public decimal Latitude
      {
         get
         {
            return this.latitudeField;
         }
         set
         {
            this.latitudeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool LatitudeSpecified
      {
         get
         {
            return this.latitudeFieldSpecified;
         }
         set
         {
            this.latitudeFieldSpecified = value;
         }
      }
      /// <remarks/>
      public Elevation Elevation
      {
         get
         {
            return this.elevationField;
         }
         set
         {
            this.elevationField = value;
         }
      }
      /// <remarks/>
      public double CADModelAzimuth
      {
         get
         {
            return this.cADModelAzimuthField;
         }
         set
         {
            this.cADModelAzimuthField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool CADModelAzimuthSpecified
      {
         get
         {
            return this.cADModelAzimuthFieldSpecified;
         }
         set
         {
            this.cADModelAzimuthFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class StationId
   {
      private stationIdTypeEnum iDTypeField;
      private bool iDTypeFieldSpecified;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public stationIdTypeEnum IDType
      {
         get
         {
            return this.iDTypeField;
         }
         set
         {
            this.iDTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool IDTypeSpecified
      {
         get
         {
            return this.iDTypeFieldSpecified;
         }
         set
         {
            this.iDTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Elevation
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Surface
   {
      private object[] itemsField;
      private ItemsChoiceType6[] itemsElementNameField;
      private string idField;
      private surfaceTypeEnum surfaceTypeField;
      private string constructionIdRefField;
      private string scheduleShadeIdRefField;
      private bool exposedToSunField;
      private string ifcGUIDField;
      public Surface()
      {
         this.exposedToSunField = true;
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AdjacentSpaceId", typeof(AdjacentSpaceId))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("FamilyName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Opening", typeof(Opening))]
      [System.Xml.Serialization.XmlElementAttribute("PlanarGeometry", typeof(PlanarGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("RectangularGeometry", typeof(RectangularGeometry))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType6[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public surfaceTypeEnum surfaceType
      {
         get
         {
            return this.surfaceTypeField;
         }
         set
         {
            this.surfaceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string constructionIdRef
      {
         get
         {
            return this.constructionIdRefField;
         }
         set
         {
            this.constructionIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleShadeIdRef
      {
         get
         {
            return this.scheduleShadeIdRefField;
         }
         set
         {
            this.scheduleShadeIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      [System.ComponentModel.DefaultValueAttribute(true)]
      public bool exposedToSun
      {
         get
         {
            return this.exposedToSunField;
         }
         set
         {
            this.exposedToSunField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AdjacentSpaceId
   {
      private string spaceIdRefField;
      private surfaceTypeEnum surfaceTypeField;
      private bool surfaceTypeFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string spaceIdRef
      {
         get
         {
            return this.spaceIdRefField;
         }
         set
         {
            this.spaceIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public surfaceTypeEnum surfaceType
      {
         get
         {
            return this.surfaceTypeField;
         }
         set
         {
            this.surfaceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool surfaceTypeSpecified
      {
         get
         {
            return this.surfaceTypeFieldSpecified;
         }
         set
         {
            this.surfaceTypeFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Opening
   {
      private object[] itemsField;
      private ItemsChoiceType5[] itemsElementNameField;
      private string idField;
      private bool coordinatesAbsoluteField;
      private bool coordinatesAbsoluteFieldSpecified;
      private shadeOperationEnum interiorShadeTypeField;
      private bool interiorShadeTypeFieldSpecified;
      private shadeOperationEnum exteriorShadeTypeField;
      private bool exteriorShadeTypeFieldSpecified;
      private string windowTypeIdRefField;
      private string constructionIdRefField;
      private openingTypeEnum openingTypeField;
      private string ifcGUIDField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("GlazeConductivity", typeof(GlazeConductivity))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("NaturalVentHiTemp", typeof(NaturalVentHiTemp))]
      [System.Xml.Serialization.XmlElementAttribute("NaturalVentLoTemp", typeof(NaturalVentLoTemp))]
      [System.Xml.Serialization.XmlElementAttribute("NaturalVentOccDep", typeof(bool))]
      [System.Xml.Serialization.XmlElementAttribute("PlanarGeometry", typeof(PlanarGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("RectangularGeometry", typeof(RectangularGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      [System.Xml.Serialization.XmlElementAttribute("Setback", typeof(Setback))]
      [System.Xml.Serialization.XmlElementAttribute("ShadeControl", typeof(ShadeControl))]
      [System.Xml.Serialization.XmlElementAttribute("ShadingCoeff", typeof(ShadingCoeff))]
      [System.Xml.Serialization.XmlElementAttribute("SolarHeatGainCoeff", typeof(SolarHeatGainCoeff))]
      [System.Xml.Serialization.XmlElementAttribute("Transmittance", typeof(Transmittance))]
      [System.Xml.Serialization.XmlElementAttribute("U-value", typeof(Uvalue))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType5[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool coordinatesAbsolute
      {
         get
         {
            return this.coordinatesAbsoluteField;
         }
         set
         {
            this.coordinatesAbsoluteField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool coordinatesAbsoluteSpecified
      {
         get
         {
            return this.coordinatesAbsoluteFieldSpecified;
         }
         set
         {
            this.coordinatesAbsoluteFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public shadeOperationEnum interiorShadeType
      {
         get
         {
            return this.interiorShadeTypeField;
         }
         set
         {
            this.interiorShadeTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool interiorShadeTypeSpecified
      {
         get
         {
            return this.interiorShadeTypeFieldSpecified;
         }
         set
         {
            this.interiorShadeTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public shadeOperationEnum exteriorShadeType
      {
         get
         {
            return this.exteriorShadeTypeField;
         }
         set
         {
            this.exteriorShadeTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool exteriorShadeTypeSpecified
      {
         get
         {
            return this.exteriorShadeTypeFieldSpecified;
         }
         set
         {
            this.exteriorShadeTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string windowTypeIdRef
      {
         get
         {
            return this.windowTypeIdRefField;
         }
         set
         {
            this.windowTypeIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string constructionIdRef
      {
         get
         {
            return this.constructionIdRefField;
         }
         set
         {
            this.constructionIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public openingTypeEnum openingType
      {
         get
         {
            return this.openingTypeField;
         }
         set
         {
            this.openingTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Emittance
   {
      private unitlessUnitEnum unitField;
      private emittanceTypeEnum typeField;
      private surfaceDescriptionEnum surfaceTypeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public emittanceTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public surfaceDescriptionEnum surfaceType
      {
         get
         {
            return this.surfaceTypeField;
         }
         set
         {
            this.surfaceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class GlazeConductivity
   {
      private conductivityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conductivityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class NaturalVentHiTemp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class NaturalVentLoTemp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class RectangularGeometry
   {
      private object[] itemsField;
      private ItemsChoiceType4[] itemsElementNameField;
      private string idField;
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Azimuth", typeof(double))]
      [System.Xml.Serialization.XmlElementAttribute("CartesianPoint", typeof(CartesianPoint))]
      [System.Xml.Serialization.XmlElementAttribute("Height", typeof(Height))]
      [System.Xml.Serialization.XmlElementAttribute("PolyLoop", typeof(PolyLoop))]
      [System.Xml.Serialization.XmlElementAttribute("Tilt", typeof(double))]
      [System.Xml.Serialization.XmlElementAttribute("Width", typeof(Width))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType4[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Height
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Width
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType4
   {
      /// <remarks/>
      Azimuth,
      /// <remarks/>
      CartesianPoint,
      /// <remarks/>
      Height,
      /// <remarks/>
      PolyLoop,
      /// <remarks/>
      Tilt,
      /// <remarks/>
      Width,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Reflectance
   {
      private unitlessUnitEnum unitField;
      private reflectanceTypeEnum typeField;
      private surfaceDescriptionEnum surfaceTypeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public reflectanceTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public surfaceDescriptionEnum surfaceType
      {
         get
         {
            return this.surfaceTypeField;
         }
         set
         {
            this.surfaceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Setback
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ShadeControl
   {
      private object[] itemsField;
      private shadeTypeEnum typeField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AirTemperature", typeof(AirTemperature))]
      [System.Xml.Serialization.XmlElementAttribute("Glare", typeof(Glare))]
      [System.Xml.Serialization.XmlElementAttribute("HorizontalSolar", typeof(HorizontalSolar))]
      [System.Xml.Serialization.XmlElementAttribute("ShadeSchedule", typeof(ShadeSchedule))]
      [System.Xml.Serialization.XmlElementAttribute("SolarOnOpening", typeof(SolarOnOpening))]
      [System.Xml.Serialization.XmlElementAttribute("ZoneCoolingLoad", typeof(ZoneCoolingLoad))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public shadeTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class AirTemperature
   {
      private temperatureUnitEnum unitField;
      private airTemperatureTypeEnum typeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public airTemperatureTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Glare
   {
      private unitlessUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HorizontalSolar
   {
      private powerPerAreaUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerPerAreaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ShadeSchedule
   {
      private string scheduleIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SolarOnOpening
   {
      private powerPerAreaUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerPerAreaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ZoneCoolingLoad
   {
      private loadUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loadUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ShadingCoeff
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SolarHeatGainCoeff
   {
      private unitlessUnitEnum unitField;
      private decimal solarIncidentAngleField;
      private bool solarIncidentAngleFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal solarIncidentAngle
      {
         get
         {
            return this.solarIncidentAngleField;
         }
         set
         {
            this.solarIncidentAngleField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool solarIncidentAngleSpecified
      {
         get
         {
            return this.solarIncidentAngleFieldSpecified;
         }
         set
         {
            this.solarIncidentAngleFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Transmittance
   {
      private unitlessUnitEnum unitField;
      private radiationWavelengthTypeEnum typeField;
      private surfaceDescriptionEnum surfaceTypeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public radiationWavelengthTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public surfaceDescriptionEnum surfaceType
      {
         get
         {
            return this.surfaceTypeField;
         }
         set
         {
            this.surfaceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute("U-value", Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Uvalue
   {
      private uValueUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public uValueUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType5
   {
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Description,
      /// <remarks/>
      Emittance,
      /// <remarks/>
      GlazeConductivity,
      /// <remarks/>
      Name,
      /// <remarks/>
      NaturalVentHiTemp,
      /// <remarks/>
      NaturalVentLoTemp,
      /// <remarks/>
      NaturalVentOccDep,
      /// <remarks/>
      PlanarGeometry,
      /// <remarks/>
      RectangularGeometry,
      /// <remarks/>
      Reflectance,
      /// <remarks/>
      Setback,
      /// <remarks/>
      ShadeControl,
      /// <remarks/>
      ShadingCoeff,
      /// <remarks/>
      SolarHeatGainCoeff,
      /// <remarks/>
      Transmittance,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("U-value")]
      Uvalue,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType6
   {
      /// <remarks/>
      AdjacentSpaceId,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Description,
      /// <remarks/>
      FamilyName,
      /// <remarks/>
      Name,
      /// <remarks/>
      Opening,
      /// <remarks/>
      PlanarGeometry,
      /// <remarks/>
      RectangularGeometry,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Transportation
   {
      private object[] itemsField;
      private string idField;
      private transportationTypeEnum transportationTypeField;
      private string scheduleIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public transportationTypeEnum transportationType
      {
         get
         {
            return this.transportationTypeField;
         }
         set
         {
            this.transportationTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Vegetation
   {
      private object[] itemsField;
      private string idField;
      private vegetationTypeEnum vegetationTypeField;
      private string waterScheduleIdRefField;
      private string waterMeterIdRefField;
      private string shadeScheduleIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("BiomassDensity", typeof(BiomassDensity))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("WaterRate", typeof(WaterRate))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public vegetationTypeEnum vegetationType
      {
         get
         {
            return this.vegetationTypeField;
         }
         set
         {
            this.vegetationTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterScheduleIdRef
      {
         get
         {
            return this.waterScheduleIdRefField;
         }
         set
         {
            this.waterScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterMeterIdRef
      {
         get
         {
            return this.waterMeterIdRefField;
         }
         set
         {
            this.waterMeterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string shadeScheduleIdRef
      {
         get
         {
            return this.shadeScheduleIdRefField;
         }
         set
         {
            this.shadeScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class BiomassDensity
   {
      private densityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public densityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WaterRate
   {
      private flowUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class YearModeled
   {
      private object[] itemsField;
      private ItemsChoiceType7[] itemsElementNameField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("BeginDate", typeof(System.DateTime), DataType="date")]
      [System.Xml.Serialization.XmlElementAttribute("EndDate", typeof(System.DateTime), DataType="date")]
      [System.Xml.Serialization.XmlElementAttribute("HolidaysModeled", typeof(HolidaysModeled))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType7[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HolidaysModeled
   {
      private string nameField;
      private string descriptionField;
      private System.DateTime holidayDateField;
      private string idField;
      /// <remarks/>
      public string Name
      {
         get
         {
            return this.nameField;
         }
         set
         {
            this.nameField = value;
         }
      }
      /// <remarks/>
      public string Description
      {
         get
         {
            return this.descriptionField;
         }
         set
         {
            this.descriptionField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
      public System.DateTime HolidayDate
      {
         get
         {
            return this.holidayDateField;
         }
         set
         {
            this.holidayDateField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType7
   {
      /// <remarks/>
      BeginDate,
      /// <remarks/>
      EndDate,
      /// <remarks/>
      HolidaysModeled,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType8
   {
      /// <remarks/>
      AltEnergySource,
      /// <remarks/>
      Building,
      /// <remarks/>
      DaylightSavings,
      /// <remarks/>
      Description,
      /// <remarks/>
      ExtEquipId,
      /// <remarks/>
      Life,
      /// <remarks/>
      LightControlId,
      /// <remarks/>
      Lighting,
      /// <remarks/>
      Location,
      /// <remarks/>
      MeterId,
      /// <remarks/>
      Name,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      Surface,
      /// <remarks/>
      Transportation,
      /// <remarks/>
      Vegetation,
      /// <remarks/>
      YearModeled,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Construction
   {
      private object[] itemsField;
      private ItemsChoiceType10[] itemsElementNameField;
      private string idField;
      private string dOELibIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Absorptance", typeof(Absorptance))]
      [System.Xml.Serialization.XmlElementAttribute("Albedo", typeof(Albedo))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("ExtEquipId", typeof(ExtEquipId))]
      [System.Xml.Serialization.XmlElementAttribute("FireFace", typeof(FireFace))]
      [System.Xml.Serialization.XmlElementAttribute("LayerId", typeof(LayerId))]
      [System.Xml.Serialization.XmlElementAttribute("LoadCalcInputParameters", typeof(LoadCalcInputParameters))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PercentExisting", typeof(PercentExisting))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      [System.Xml.Serialization.XmlElementAttribute("Roughness", typeof(Roughness))]
      [System.Xml.Serialization.XmlElementAttribute("Transmittance", typeof(Transmittance))]
      [System.Xml.Serialization.XmlElementAttribute("U-value", typeof(Uvalue))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType10[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Absorptance
   {
      private unitlessUnitEnum unitField;
      private absorptanceUnitEnum typeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public absorptanceUnitEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Albedo
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FireFace
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Absorptance", typeof(Absorptance))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LayerId
   {
      private string layerIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string layerIdRef
      {
         get
         {
            return this.layerIdRefField;
         }
         set
         {
            this.layerIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LoadCalcInputParameters
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CLTDParameters", typeof(CLTDParameters))]
      [System.Xml.Serialization.XmlElementAttribute("FloorSlabHeatLossCoefficient", typeof(FloorSlabHeatLossCoefficient))]
      [System.Xml.Serialization.XmlElementAttribute("ManualJ8Parameters", typeof(ManualJ8Parameters))]
      [System.Xml.Serialization.XmlElementAttribute("RTSParameters", typeof(RTSParameters))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CLTDParameters
   {
      private roofASHRAENumberEnum roofASHRAENumberField;
      private bool roofASHRAENumberFieldSpecified;
      private wallASHRAEGroupEnum wallASHRAEGroupField;
      private bool wallASHRAEGroupFieldSpecified;
      private roofColorEnum roofColorField;
      private bool roofColorFieldSpecified;
      private bool roofHasSuspendedCeilingField;
      private bool roofHasSuspendedCeilingFieldSpecified;
      private wallColorEnum wallColorField;
      private bool wallColorFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public roofASHRAENumberEnum roofASHRAENumber
      {
         get
         {
            return this.roofASHRAENumberField;
         }
         set
         {
            this.roofASHRAENumberField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool roofASHRAENumberSpecified
      {
         get
         {
            return this.roofASHRAENumberFieldSpecified;
         }
         set
         {
            this.roofASHRAENumberFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public wallASHRAEGroupEnum wallASHRAEGroup
      {
         get
         {
            return this.wallASHRAEGroupField;
         }
         set
         {
            this.wallASHRAEGroupField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool wallASHRAEGroupSpecified
      {
         get
         {
            return this.wallASHRAEGroupFieldSpecified;
         }
         set
         {
            this.wallASHRAEGroupFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public roofColorEnum roofColor
      {
         get
         {
            return this.roofColorField;
         }
         set
         {
            this.roofColorField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool roofColorSpecified
      {
         get
         {
            return this.roofColorFieldSpecified;
         }
         set
         {
            this.roofColorFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool roofHasSuspendedCeiling
      {
         get
         {
            return this.roofHasSuspendedCeilingField;
         }
         set
         {
            this.roofHasSuspendedCeilingField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool roofHasSuspendedCeilingSpecified
      {
         get
         {
            return this.roofHasSuspendedCeilingFieldSpecified;
         }
         set
         {
            this.roofHasSuspendedCeilingFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public wallColorEnum wallColor
      {
         get
         {
            return this.wallColorField;
         }
         set
         {
            this.wallColorField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool wallColorSpecified
      {
         get
         {
            return this.wallColorFieldSpecified;
         }
         set
         {
            this.wallColorFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FloorSlabHeatLossCoefficient
   {
      private floorSlabPerimeterHeatLossCoefficientUnitTypeEnum floorSlabPerimeterHeatLossCoefficientUnitTypeEnumField;
      private bool floorSlabPerimeterHeatLossCoefficientUnitTypeEnumFieldSpecified;
      private float valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public floorSlabPerimeterHeatLossCoefficientUnitTypeEnum floorSlabPerimeterHeatLossCoefficientUnitTypeEnum
      {
         get
         {
            return this.floorSlabPerimeterHeatLossCoefficientUnitTypeEnumField;
         }
         set
         {
            this.floorSlabPerimeterHeatLossCoefficientUnitTypeEnumField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool floorSlabPerimeterHeatLossCoefficientUnitTypeEnumSpecified
      {
         get
         {
            return this.floorSlabPerimeterHeatLossCoefficientUnitTypeEnumFieldSpecified;
         }
         set
         {
            this.floorSlabPerimeterHeatLossCoefficientUnitTypeEnumFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public float Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ManualJ8Parameters
   {
      private wallGroupManualJEnum wallGroupManualJField;
      private bool wallGroupManualJFieldSpecified;
      private roofCLTDIndexEnum roofCLTDIndexField;
      private bool roofCLTDIndexFieldSpecified;
      private bool floorIsRadiantField;
      private bool floorIsRadiantFieldSpecified;
      private float floorCrawlSpaceWallUValueField;
      private bool floorCrawlSpaceWallUValueFieldSpecified;
      private bool floorCrawlSpaceIsSealedField;
      private bool floorCrawlSpaceIsSealedFieldSpecified;
      private floorCategoryEnum floorCategoryField;
      private bool floorCategoryFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public wallGroupManualJEnum wallGroupManualJ
      {
         get
         {
            return this.wallGroupManualJField;
         }
         set
         {
            this.wallGroupManualJField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool wallGroupManualJSpecified
      {
         get
         {
            return this.wallGroupManualJFieldSpecified;
         }
         set
         {
            this.wallGroupManualJFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public roofCLTDIndexEnum roofCLTDIndex
      {
         get
         {
            return this.roofCLTDIndexField;
         }
         set
         {
            this.roofCLTDIndexField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool roofCLTDIndexSpecified
      {
         get
         {
            return this.roofCLTDIndexFieldSpecified;
         }
         set
         {
            this.roofCLTDIndexFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool floorIsRadiant
      {
         get
         {
            return this.floorIsRadiantField;
         }
         set
         {
            this.floorIsRadiantField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool floorIsRadiantSpecified
      {
         get
         {
            return this.floorIsRadiantFieldSpecified;
         }
         set
         {
            this.floorIsRadiantFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public float floorCrawlSpaceWallUValue
      {
         get
         {
            return this.floorCrawlSpaceWallUValueField;
         }
         set
         {
            this.floorCrawlSpaceWallUValueField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool floorCrawlSpaceWallUValueSpecified
      {
         get
         {
            return this.floorCrawlSpaceWallUValueFieldSpecified;
         }
         set
         {
            this.floorCrawlSpaceWallUValueFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool floorCrawlSpaceIsSealed
      {
         get
         {
            return this.floorCrawlSpaceIsSealedField;
         }
         set
         {
            this.floorCrawlSpaceIsSealedField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool floorCrawlSpaceIsSealedSpecified
      {
         get
         {
            return this.floorCrawlSpaceIsSealedFieldSpecified;
         }
         set
         {
            this.floorCrawlSpaceIsSealedFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public floorCategoryEnum floorCategory
      {
         get
         {
            return this.floorCategoryField;
         }
         set
         {
            this.floorCategoryField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool floorCategorySpecified
      {
         get
         {
            return this.floorCategoryFieldSpecified;
         }
         set
         {
            this.floorCategoryFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class RTSParameters
   {
      private HOutside itemField;
      private roofCTSTypeEnum roofCTSTypeField;
      private bool roofCTSTypeFieldSpecified;
      private wallCTSTypeEnum wallCTSTypeField;
      private bool wallCTSTypeFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("HOutside")]
      public HOutside Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public roofCTSTypeEnum roofCTSType
      {
         get
         {
            return this.roofCTSTypeField;
         }
         set
         {
            this.roofCTSTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool roofCTSTypeSpecified
      {
         get
         {
            return this.roofCTSTypeFieldSpecified;
         }
         set
         {
            this.roofCTSTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public wallCTSTypeEnum wallCTSType
      {
         get
         {
            return this.wallCTSTypeField;
         }
         set
         {
            this.wallCTSTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool wallCTSTypeSpecified
      {
         get
         {
            return this.wallCTSTypeFieldSpecified;
         }
         set
         {
            this.wallCTSTypeFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HOutside
   {
      private hOutsideUnitTypeEnum hOutsideUnitTypeEnumField;
      private bool hOutsideUnitTypeEnumFieldSpecified;
      private float valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public hOutsideUnitTypeEnum hOutsideUnitTypeEnum
      {
         get
         {
            return this.hOutsideUnitTypeEnumField;
         }
         set
         {
            this.hOutsideUnitTypeEnumField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool hOutsideUnitTypeEnumSpecified
      {
         get
         {
            return this.hOutsideUnitTypeEnumFieldSpecified;
         }
         set
         {
            this.hOutsideUnitTypeEnumFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public float Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PercentExisting
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Roughness
   {
      private roughnessValueEnum valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public roughnessValueEnum value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType10
   {
      /// <remarks/>
      Absorptance,
      /// <remarks/>
      Albedo,
      /// <remarks/>
      Cost,
      /// <remarks/>
      Description,
      /// <remarks/>
      Emittance,
      /// <remarks/>
      ExtEquipId,
      /// <remarks/>
      FireFace,
      /// <remarks/>
      LayerId,
      /// <remarks/>
      LoadCalcInputParameters,
      /// <remarks/>
      Name,
      /// <remarks/>
      PercentExisting,
      /// <remarks/>
      Reflectance,
      /// <remarks/>
      Roughness,
      /// <remarks/>
      Transmittance,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("U-value")]
      Uvalue,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DaySchedule
   {
      private object[] itemsField;
      private ItemsChoiceType21[] itemsElementNameField;
      private string idField;
      private scheduleTypeEnum scheduleTypeField;
      private string scheduleTypeLimitsIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ScheduleValue", typeof(ScheduleValue))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType21[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public scheduleTypeEnum scheduleType
      {
         get
         {
            return this.scheduleTypeField;
         }
         set
         {
            this.scheduleTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string scheduleTypeLimitsId
      {
         get
         {
            return this.scheduleTypeLimitsIdField;
         }
         set
         {
            this.scheduleTypeLimitsIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ScheduleValue
   {
      private decimal outsideHighResetField;
      private bool outsideHighResetFieldSpecified;
      private decimal outsideLowResetField;
      private bool outsideLowResetFieldSpecified;
      private decimal supplyHighResetField;
      private bool supplyHighResetFieldSpecified;
      private decimal supplyLowResetField;
      private bool supplyLowResetFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal OutsideHighReset
      {
         get
         {
            return this.outsideHighResetField;
         }
         set
         {
            this.outsideHighResetField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool OutsideHighResetSpecified
      {
         get
         {
            return this.outsideHighResetFieldSpecified;
         }
         set
         {
            this.outsideHighResetFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal OutsideLowReset
      {
         get
         {
            return this.outsideLowResetField;
         }
         set
         {
            this.outsideLowResetField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool OutsideLowResetSpecified
      {
         get
         {
            return this.outsideLowResetFieldSpecified;
         }
         set
         {
            this.outsideLowResetFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal SupplyHighReset
      {
         get
         {
            return this.supplyHighResetField;
         }
         set
         {
            this.supplyHighResetField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool SupplyHighResetSpecified
      {
         get
         {
            return this.supplyHighResetFieldSpecified;
         }
         set
         {
            this.supplyHighResetFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal SupplyLowReset
      {
         get
         {
            return this.supplyLowResetField;
         }
         set
         {
            this.supplyLowResetField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool SupplyLowResetSpecified
      {
         get
         {
            return this.supplyLowResetFieldSpecified;
         }
         set
         {
            this.supplyLowResetFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType21
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      ScheduleValue,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DocumentHistory
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CreatedBy", typeof(CreatedBy))]
      [System.Xml.Serialization.XmlElementAttribute("ModifiedBy", typeof(ModifiedBy))]
      [System.Xml.Serialization.XmlElementAttribute("PersonInfo", typeof(PersonInfo))]
      [System.Xml.Serialization.XmlElementAttribute("ProgramInfo", typeof(ProgramInfo))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CreatedBy
   {
      private CADModelId[] itemsField;
      private string personIdField;
      private string programIdField;
      private System.DateTime dateField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CADModelId")]
      public CADModelId[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string personId
      {
         get
         {
            return this.personIdField;
         }
         set
         {
            this.personIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public System.DateTime date
      {
         get
         {
            return this.dateField;
         }
         set
         {
            this.dateField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CADModelId
   {
      private string programIdRefField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programIdRef
      {
         get
         {
            return this.programIdRefField;
         }
         set
         {
            this.programIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ModifiedBy
   {
      private string personIdField;
      private string programIdField;
      private System.DateTime dateField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string personId
      {
         get
         {
            return this.personIdField;
         }
         set
         {
            this.personIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public System.DateTime date
      {
         get
         {
            return this.dateField;
         }
         set
         {
            this.dateField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PersonInfo
   {
      private string[] itemsField;
      private ItemsChoiceType38[] itemsElementNameField;
      private string idField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Address1", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Address2", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("City", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("CompanyName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Country", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Email1Address", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("FirstName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("LastName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("MiddleName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PhoneNumber", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("State", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("WebPage", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ZipCode", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType38[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType38
   {
      /// <remarks/>
      Address1,
      /// <remarks/>
      Address2,
      /// <remarks/>
      City,
      /// <remarks/>
      CompanyName,
      /// <remarks/>
      Country,
      /// <remarks/>
      Email1Address,
      /// <remarks/>
      FirstName,
      /// <remarks/>
      LastName,
      /// <remarks/>
      MiddleName,
      /// <remarks/>
      PhoneNumber,
      /// <remarks/>
      State,
      /// <remarks/>
      WebPage,
      /// <remarks/>
      ZipCode,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ProgramInfo
   {
      private object[] itemsField;
      private ItemsChoiceType37[] itemsElementNameField;
      private string idField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CompanyName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Platform", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ProductName", typeof(ProductName))]
      [System.Xml.Serialization.XmlElementAttribute("ProjectEntity", typeof(ProjectEntity))]
      [System.Xml.Serialization.XmlElementAttribute("Version", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType37[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ProductName
   {
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ProjectEntity
   {
      private object[] itemsField;
      private ItemsChoiceType36[] itemsElementNameField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("FileName", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("GUID", typeof(GUID))]
      [System.Xml.Serialization.XmlElementAttribute("URI", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType36[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class GUID
   {
      private entityTypeEnum entityField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public entityTypeEnum entity
      {
         get
         {
            return this.entityField;
         }
         set
         {
            this.entityField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType36
   {
      /// <remarks/>
      FileName,
      /// <remarks/>
      GUID,
      /// <remarks/>
      URI,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType37
   {
      /// <remarks/>
      CompanyName,
      /// <remarks/>
      Platform,
      /// <remarks/>
      ProductName,
      /// <remarks/>
      ProjectEntity,
      /// <remarks/>
      Version,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ExtEquip
   {
      private object[] itemsField;
      private ItemsChoiceType32[] itemsElementNameField;
      private string idField;
      private string scheduleIdRefField;
      private string waterTempScheduleIdRefField;
      private string hydronicLoopIdRefField;
      private string waterScheduleIdRefField;
      private string waterMeterIdRefField;
      private extEquipTypeEnum typeField;
      private string airLoopIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Age", typeof(Age))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("CyclesPerWeek", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Efficiency", typeof(Efficiency))]
      [System.Xml.Serialization.XmlElementAttribute("ElecLoad", typeof(ElecLoad))]
      [System.Xml.Serialization.XmlElementAttribute("Energy", typeof(Energy))]
      [System.Xml.Serialization.XmlElementAttribute("FuelLoad", typeof(FuelLoad))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("IndoorAirQuality", typeof(IndoorAirQuality))]
      [System.Xml.Serialization.XmlElementAttribute("LatentLoad", typeof(LatentLoad))]
      [System.Xml.Serialization.XmlElementAttribute("Manufacturer", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Model", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Performance", typeof(Performance))]
      [System.Xml.Serialization.XmlElementAttribute("Power", typeof(Power))]
      [System.Xml.Serialization.XmlElementAttribute("RatedFlow", typeof(RatedFlow))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("WasteWaterHREff", typeof(WasteWaterHREff))]
      [System.Xml.Serialization.XmlElementAttribute("WaterUsePerCycle", typeof(WaterUsePerCycle))]
      [System.Xml.Serialization.XmlElementAttribute("Weight", typeof(Weight))]
      [System.Xml.Serialization.XmlElementAttribute("WindSpeed", typeof(WindSpeed))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType32[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterTempScheduleIdRef
      {
         get
         {
            return this.waterTempScheduleIdRefField;
         }
         set
         {
            this.waterTempScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterScheduleIdRef
      {
         get
         {
            return this.waterScheduleIdRefField;
         }
         set
         {
            this.waterScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterMeterIdRef
      {
         get
         {
            return this.waterMeterIdRefField;
         }
         set
         {
            this.waterMeterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public extEquipTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string airLoopIdRef
      {
         get
         {
            return this.airLoopIdRefField;
         }
         set
         {
            this.airLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Age
   {
      private AgeUnit unitField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public AgeUnit unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   public enum AgeUnit
   {
      /// <remarks/>
      Years,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ElecLoad
   {
      private powerUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FuelLoad
   {
      private fuelLoadUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public fuelLoadUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class IndoorAirQuality
   {
      private object[] itemsField;
      private string idField;
      private string scheduleIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("EmissionRate", typeof(EmissionRate))]
      [System.Xml.Serialization.XmlElementAttribute("HighLimit", typeof(HighLimit))]
      [System.Xml.Serialization.XmlElementAttribute("SinkRate", typeof(SinkRate))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class EmissionRate
   {
      private emissionUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public emissionUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HighLimit
   {
      private unitlessSmallUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessSmallUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SinkRate
   {
      private sinkRateUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public sinkRateUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LatentLoad
   {
      private loadUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loadUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WasteWaterHREff
   {
      private unitlessUnitEnum unitField;
      private string airLoopIdRefField;
      private string hydronicLoopIdRefField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string airLoopIdRef
      {
         get
         {
            return this.airLoopIdRefField;
         }
         set
         {
            this.airLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WaterUsePerCycle
   {
      private waterUseUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public waterUseUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WindSpeed
   {
      private velocityUnitEnum unitField;
      private windSpeedEnum typeField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public velocityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public windSpeedEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType32
   {
      /// <remarks/>
      Age,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Cost,
      /// <remarks/>
      CyclesPerWeek,
      /// <remarks/>
      Description,
      /// <remarks/>
      Efficiency,
      /// <remarks/>
      ElecLoad,
      /// <remarks/>
      Energy,
      /// <remarks/>
      FuelLoad,
      /// <remarks/>
      GeneralGeometry,
      /// <remarks/>
      IndoorAirQuality,
      /// <remarks/>
      LatentLoad,
      /// <remarks/>
      Manufacturer,
      /// <remarks/>
      Model,
      /// <remarks/>
      Name,
      /// <remarks/>
      Performance,
      /// <remarks/>
      Power,
      /// <remarks/>
      RatedFlow,
      /// <remarks/>
      Reference,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      WasteWaterHREff,
      /// <remarks/>
      WaterUsePerCycle,
      /// <remarks/>
      Weight,
      /// <remarks/>
      WindSpeed,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HydronicLoop
   {
      private object[] itemsField;
      private ItemsChoiceType30[] itemsElementNameField;
      private loopTypeEnum loopTypeField;
      private string controlZoneIdRefField;
      private string primaryLoopIdField;
      private fluidTypeEnum fluidTypeField;
      private string idField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("DesignCoolT", typeof(DesignCoolT))]
      [System.Xml.Serialization.XmlElementAttribute("FlowControl", typeof(FlowControl))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoopEquipment", typeof(HydronicLoopEquipment))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("TemperatureControl", typeof(TemperatureControl))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType30[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public loopTypeEnum loopType
      {
         get
         {
            return this.loopTypeField;
         }
         set
         {
            this.loopTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string controlZoneIdRef
      {
         get
         {
            return this.controlZoneIdRefField;
         }
         set
         {
            this.controlZoneIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string primaryLoopId
      {
         get
         {
            return this.primaryLoopIdField;
         }
         set
         {
            this.primaryLoopIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public fluidTypeEnum fluidType
      {
         get
         {
            return this.fluidTypeField;
         }
         set
         {
            this.fluidTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DesignCoolT
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FlowControl
   {
      private object[] itemsField;
      private string processScheduleIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("DesignFlow", typeof(DesignFlow))]
      [System.Xml.Serialization.XmlElementAttribute("MaximumFlow", typeof(MaximumFlow))]
      [System.Xml.Serialization.XmlElementAttribute("MinimumFlow", typeof(MinimumFlow))]
      [System.Xml.Serialization.XmlElementAttribute("RecircFlow", typeof(RecircFlow))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string processScheduleId
      {
         get
         {
            return this.processScheduleIdField;
         }
         set
         {
            this.processScheduleIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DesignFlow
   {
      private flowUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinimumFlow
   {
      private flowUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class RecircFlow
   {
      private flowUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HydronicLoopEquipment
   {
      private object[] itemsField;
      private ItemsChoiceType29[] itemsElementNameField;
      private string idField;
      private hydronicEquipTypeEnum equipmentTypeField;
      private string waterMeterIdRefField;
      private string waterScheduleIdRefField;
      private string primaryLoopIdField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Age", typeof(Age))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Capacity", typeof(Capacity))]
      [System.Xml.Serialization.XmlElementAttribute("Control", typeof(Control))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("DeltaP", typeof(DeltaP))]
      [System.Xml.Serialization.XmlElementAttribute("DeltaT", typeof(DeltaT))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Efficiency", typeof(Efficiency))]
      [System.Xml.Serialization.XmlElementAttribute("Energy", typeof(Energy))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoopId", typeof(HydronicLoopId))]
      [System.Xml.Serialization.XmlElementAttribute("Life", typeof(Life))]
      [System.Xml.Serialization.XmlElementAttribute("Manufacturer", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("MinFlow", typeof(MinFlow))]
      [System.Xml.Serialization.XmlElementAttribute("Model", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("OperationSchedule", typeof(OperationSchedule))]
      [System.Xml.Serialization.XmlElementAttribute("Performance", typeof(Performance))]
      [System.Xml.Serialization.XmlElementAttribute("Power", typeof(Power))]
      [System.Xml.Serialization.XmlElementAttribute("RatedFlow", typeof(RatedFlow))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("RefrigerantType", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ResetTemperature", typeof(ResetTemperature))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("Temp", typeof(Temp))]
      [System.Xml.Serialization.XmlElementAttribute("Weight", typeof(Weight))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType29[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public hydronicEquipTypeEnum equipmentType
      {
         get
         {
            return this.equipmentTypeField;
         }
         set
         {
            this.equipmentTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterMeterIdRef
      {
         get
         {
            return this.waterMeterIdRefField;
         }
         set
         {
            this.waterMeterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterScheduleIdRef
      {
         get
         {
            return this.waterScheduleIdRefField;
         }
         set
         {
            this.waterScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string primaryLoopId
      {
         get
         {
            return this.primaryLoopIdField;
         }
         set
         {
            this.primaryLoopIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType29
   {
      /// <remarks/>
      Age,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Capacity,
      /// <remarks/>
      Control,
      /// <remarks/>
      Cost,
      /// <remarks/>
      DeltaP,
      /// <remarks/>
      DeltaT,
      /// <remarks/>
      Description,
      /// <remarks/>
      Efficiency,
      /// <remarks/>
      Energy,
      /// <remarks/>
      GeneralGeometry,
      /// <remarks/>
      HydronicLoopId,
      /// <remarks/>
      Life,
      /// <remarks/>
      Manufacturer,
      /// <remarks/>
      MinFlow,
      /// <remarks/>
      Model,
      /// <remarks/>
      Name,
      /// <remarks/>
      OperationSchedule,
      /// <remarks/>
      Performance,
      /// <remarks/>
      Power,
      /// <remarks/>
      RatedFlow,
      /// <remarks/>
      Reference,
      /// <remarks/>
      RefrigerantType,
      /// <remarks/>
      ResetTemperature,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      Temp,
      /// <remarks/>
      Weight,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType30
   {
      /// <remarks/>
      Cost,
      /// <remarks/>
      Description,
      /// <remarks/>
      DesignCoolT,
      /// <remarks/>
      FlowControl,
      /// <remarks/>
      HydronicLoopEquipment,
      /// <remarks/>
      Name,
      /// <remarks/>
      Reference,
      /// <remarks/>
      TemperatureControl,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class IntEquip
   {
      private object[] itemsField;
      private ItemsChoiceType31[] itemsElementNameField;
      private string idField;
      private string scheduleIdRefField;
      private string waterTempScheduleIdRefField;
      private string hydronicLoopIdRefField;
      private string waterScheduleIdRefField;
      private string waterMeterIdRefField;
      private intEquipTypeEnum typeField;
      private string airLoopIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Age", typeof(Age))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("CyclesPerWeek", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Efficiency", typeof(Efficiency))]
      [System.Xml.Serialization.XmlElementAttribute("ElecLoad", typeof(ElecLoad))]
      [System.Xml.Serialization.XmlElementAttribute("Energy", typeof(Energy))]
      [System.Xml.Serialization.XmlElementAttribute("FuelLoad", typeof(FuelLoad))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("HeatRejectedtoSpace", typeof(HeatRejectedtoSpace))]
      [System.Xml.Serialization.XmlElementAttribute("IndoorAirQuality", typeof(IndoorAirQuality))]
      [System.Xml.Serialization.XmlElementAttribute("LatentLoad", typeof(LatentLoad))]
      [System.Xml.Serialization.XmlElementAttribute("Manufacturer", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Model", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Performance", typeof(Performance))]
      [System.Xml.Serialization.XmlElementAttribute("Power", typeof(Power))]
      [System.Xml.Serialization.XmlElementAttribute("RatedFlow", typeof(RatedFlow))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("WasteWaterHREff", typeof(WasteWaterHREff))]
      [System.Xml.Serialization.XmlElementAttribute("WaterUsePerCycle", typeof(WaterUsePerCycle))]
      [System.Xml.Serialization.XmlElementAttribute("Weight", typeof(Weight))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType31[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string scheduleIdRef
      {
         get
         {
            return this.scheduleIdRefField;
         }
         set
         {
            this.scheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterTempScheduleIdRef
      {
         get
         {
            return this.waterTempScheduleIdRefField;
         }
         set
         {
            this.waterTempScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string hydronicLoopIdRef
      {
         get
         {
            return this.hydronicLoopIdRefField;
         }
         set
         {
            this.hydronicLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterScheduleIdRef
      {
         get
         {
            return this.waterScheduleIdRefField;
         }
         set
         {
            this.waterScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string waterMeterIdRef
      {
         get
         {
            return this.waterMeterIdRefField;
         }
         set
         {
            this.waterMeterIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public intEquipTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string airLoopIdRef
      {
         get
         {
            return this.airLoopIdRefField;
         }
         set
         {
            this.airLoopIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HeatRejectedtoSpace
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType31
   {
      /// <remarks/>
      Age,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      Cost,
      /// <remarks/>
      CyclesPerWeek,
      /// <remarks/>
      Description,
      /// <remarks/>
      Efficiency,
      /// <remarks/>
      ElecLoad,
      /// <remarks/>
      Energy,
      /// <remarks/>
      FuelLoad,
      /// <remarks/>
      GeneralGeometry,
      /// <remarks/>
      HeatRejectedtoSpace,
      /// <remarks/>
      IndoorAirQuality,
      /// <remarks/>
      LatentLoad,
      /// <remarks/>
      Manufacturer,
      /// <remarks/>
      Model,
      /// <remarks/>
      Name,
      /// <remarks/>
      Performance,
      /// <remarks/>
      Power,
      /// <remarks/>
      RatedFlow,
      /// <remarks/>
      Reference,
      /// <remarks/>
      ShellGeometry,
      /// <remarks/>
      WasteWaterHREff,
      /// <remarks/>
      WaterUsePerCycle,
      /// <remarks/>
      Weight,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Layer
   {
      private object[] itemsField;
      private ItemsChoiceType11[] itemsElementNameField;
      private string idField;
      private string dOELibIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("HOutside", typeof(HOutside))]
      [System.Xml.Serialization.XmlElementAttribute("InsideAirFilmResistance", typeof(InsideAirFilmResistance))]
      [System.Xml.Serialization.XmlElementAttribute("MaterialId", typeof(MaterialId))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType11[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class InsideAirFilmResistance
   {
      private resistanceUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resistanceUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MaterialId
   {
      private string materialIdRefField;
      private double percentOfLayerField;
      private bool percentOfLayerFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string materialIdRef
      {
         get
         {
            return this.materialIdRefField;
         }
         set
         {
            this.materialIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public double percentOfLayer
      {
         get
         {
            return this.percentOfLayerField;
         }
         set
         {
            this.percentOfLayerField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool percentOfLayerSpecified
      {
         get
         {
            return this.percentOfLayerFieldSpecified;
         }
         set
         {
            this.percentOfLayerFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType11
   {
      /// <remarks/>
      Cost,
      /// <remarks/>
      Description,
      /// <remarks/>
      HOutside,
      /// <remarks/>
      InsideAirFilmResistance,
      /// <remarks/>
      MaterialId,
      /// <remarks/>
      Name,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LightingSystem
   {
      private object[] itemsField;
      private ItemsChoiceType9[] itemsElementNameField;
      private string idField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Ballast", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("CoefficientOfUtilization", typeof(CoefficientOfUtilization))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("Dimensions", typeof(Dimensions))]
      [System.Xml.Serialization.XmlElementAttribute("GeneralGeometry", typeof(GeneralGeometry))]
      [System.Xml.Serialization.XmlElementAttribute("InputWatts", typeof(InputWatts))]
      [System.Xml.Serialization.XmlElementAttribute("Lamp", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("LumensPerLamp", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Luminaire", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Manufacturer", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("NumberOfLamps", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("Photometry", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ShellGeometry", typeof(ShellGeometry))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType9[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Dimensions
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Height", typeof(Height))]
      [System.Xml.Serialization.XmlElementAttribute("Length", typeof(Length))]
      [System.Xml.Serialization.XmlElementAttribute("Width", typeof(Width))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Length
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class InputWatts
   {
      private powerUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public powerUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType9
   {
      /// <remarks/>
      Ballast,
      /// <remarks/>
      CoefficientOfUtilization,
      /// <remarks/>
      Cost,
      /// <remarks/>
      Dimensions,
      /// <remarks/>
      GeneralGeometry,
      /// <remarks/>
      InputWatts,
      /// <remarks/>
      Lamp,
      /// <remarks/>
      LumensPerLamp,
      /// <remarks/>
      Luminaire,
      /// <remarks/>
      Manufacturer,
      /// <remarks/>
      NumberOfLamps,
      /// <remarks/>
      Photometry,
      /// <remarks/>
      Reference,
      /// <remarks/>
      ShellGeometry,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Material
   {
      private object[] itemsField;
      private ItemsChoiceType12[] itemsElementNameField;
      private string idField;
      private string dOELibIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Absorptance", typeof(Absorptance))]
      [System.Xml.Serialization.XmlElementAttribute("Albedo", typeof(Albedo))]
      [System.Xml.Serialization.XmlElementAttribute("CADMaterialId", typeof(CADMaterialId))]
      [System.Xml.Serialization.XmlElementAttribute("Conductivity", typeof(Conductivity))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("Density", typeof(Density))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("Fire", typeof(Fire))]
      [System.Xml.Serialization.XmlElementAttribute("ImageTexture", typeof(ImageTexture))]
      [System.Xml.Serialization.XmlElementAttribute("IndoorAirQuality", typeof(IndoorAirQuality))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Permeance", typeof(Permeance))]
      [System.Xml.Serialization.XmlElementAttribute("Porosity", typeof(Porosity))]
      [System.Xml.Serialization.XmlElementAttribute("R-value", typeof(Rvalue))]
      [System.Xml.Serialization.XmlElementAttribute("RecycledContent", typeof(RecycledContent))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      [System.Xml.Serialization.XmlElementAttribute("Roughness", typeof(Roughness))]
      [System.Xml.Serialization.XmlElementAttribute("SpecificHeat", typeof(SpecificHeat))]
      [System.Xml.Serialization.XmlElementAttribute("Thickness", typeof(Thickness))]
      [System.Xml.Serialization.XmlElementAttribute("Transmittance", typeof(Transmittance))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType12[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CADMaterialId
   {
      private string cADMaterialIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string CADMaterialIdRef
      {
         get
         {
            return this.cADMaterialIdRefField;
         }
         set
         {
            this.cADMaterialIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Conductivity
   {
      private conductivityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conductivityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Density
   {
      private densityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public densityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Fire
   {
      private object itemField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Conductivity", typeof(Conductivity))]
      [System.Xml.Serialization.XmlElementAttribute("Density", typeof(Density))]
      [System.Xml.Serialization.XmlElementAttribute("SpecificHeat", typeof(SpecificHeat))]
      [System.Xml.Serialization.XmlElementAttribute("Thickness", typeof(Thickness))]
      public object Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SpecificHeat
   {
      private specificHeatUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public specificHeatUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Thickness
   {
      private lengthUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public lengthUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ImageTexture
   {
      private string urlField;
      private bool repeatSField;
      private bool repeatTField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string url
      {
         get
         {
            return this.urlField;
         }
         set
         {
            this.urlField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool repeatS
      {
         get
         {
            return this.repeatSField;
         }
         set
         {
            this.repeatSField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public bool repeatT
      {
         get
         {
            return this.repeatTField;
         }
         set
         {
            this.repeatTField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Permeance
   {
      private permUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public permUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Porosity
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute("R-value", Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Rvalue
   {
      private resistanceUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resistanceUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class RecycledContent
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType12
   {
      /// <remarks/>
      Absorptance,
      /// <remarks/>
      Albedo,
      /// <remarks/>
      CADMaterialId,
      /// <remarks/>
      Conductivity,
      /// <remarks/>
      Cost,
      /// <remarks/>
      Density,
      /// <remarks/>
      Description,
      /// <remarks/>
      Emittance,
      /// <remarks/>
      Fire,
      /// <remarks/>
      ImageTexture,
      /// <remarks/>
      IndoorAirQuality,
      /// <remarks/>
      Name,
      /// <remarks/>
      Permeance,
      /// <remarks/>
      Porosity,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("R-value")]
      Rvalue,
      /// <remarks/>
      RecycledContent,
      /// <remarks/>
      Reference,
      /// <remarks/>
      Reflectance,
      /// <remarks/>
      Roughness,
      /// <remarks/>
      SpecificHeat,
      /// <remarks/>
      Thickness,
      /// <remarks/>
      Transmittance,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Meter
   {
      private object[] itemsField;
      private ItemsChoiceType34[] itemsElementNameField;
      private string idField;
      private resourceTypeEnum resourceTypeField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAnyElementAttribute()]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("UtilityRate", typeof(UtilityRate))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType34[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resourceTypeEnum resourceType
      {
         get
         {
            return this.resourceTypeField;
         }
         set
         {
            this.resourceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class UtilityRate
   {
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType34
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("##any:")]
      Item,
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      UtilityRate,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Results
   {
      private object[] itemsField;
      private ItemsChoiceType35[] itemsElementNameField;
      private string idField;
      private string unitField;
      private currencyTypeEnum currencyField;
      private bool currencyFieldSpecified;
      private resultsTypeEnum resultsTypeField;
      private bool resultsTypeFieldSpecified;
      private resourceTypeEnum resourceTypeField;
      private string programIdField;
      private valueTypeEnum valueTypeField;
      private bool valueTypeFieldSpecified;
      private System.DateTime startTimeField;
      private string timeIncrementField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("CartesianPoint", typeof(CartesianPoint))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("ObjectId", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Value", typeof(decimal))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType35[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public currencyTypeEnum currency
      {
         get
         {
            return this.currencyField;
         }
         set
         {
            this.currencyField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool currencySpecified
      {
         get
         {
            return this.currencyFieldSpecified;
         }
         set
         {
            this.currencyFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resultsTypeEnum resultsType
      {
         get
         {
            return this.resultsTypeField;
         }
         set
         {
            this.resultsTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool resultsTypeSpecified
      {
         get
         {
            return this.resultsTypeFieldSpecified;
         }
         set
         {
            this.resultsTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public resourceTypeEnum resourceType
      {
         get
         {
            return this.resourceTypeField;
         }
         set
         {
            this.resourceTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public valueTypeEnum valueType
      {
         get
         {
            return this.valueTypeField;
         }
         set
         {
            this.valueTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool valueTypeSpecified
      {
         get
         {
            return this.valueTypeFieldSpecified;
         }
         set
         {
            this.valueTypeFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public System.DateTime startTime
      {
         get
         {
            return this.startTimeField;
         }
         set
         {
            this.startTimeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="duration")]
      public string timeIncrement
      {
         get
         {
            return this.timeIncrementField;
         }
         set
         {
            this.timeIncrementField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType35
   {
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      CartesianPoint,
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      ObjectId,
      /// <remarks/>
      Value,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Schedule
   {
      private object[] itemsField;
      private ItemsChoiceType19[] itemsElementNameField;
      private string idField;
      private scheduleTypeEnum typeField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("YearSchedule", typeof(YearSchedule))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType19[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public scheduleTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class YearSchedule
   {
      private object[] itemsField;
      private ItemsChoiceType18[] itemsElementNameField;
      private string idField;
      private string scheduleTypeLimitsIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("BeginDate", typeof(System.DateTime), DataType="date")]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("EndDate", typeof(System.DateTime), DataType="date")]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("WeekScheduleId", typeof(WeekScheduleId))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType18[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string scheduleTypeLimitsId
      {
         get
         {
            return this.scheduleTypeLimitsIdField;
         }
         set
         {
            this.scheduleTypeLimitsIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WeekScheduleId
   {
      private string weekScheduleIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string weekScheduleIdRef
      {
         get
         {
            return this.weekScheduleIdRefField;
         }
         set
         {
            this.weekScheduleIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType18
   {
      /// <remarks/>
      BeginDate,
      /// <remarks/>
      Description,
      /// <remarks/>
      EndDate,
      /// <remarks/>
      Name,
      /// <remarks/>
      WeekScheduleId,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType19
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      YearSchedule,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SimulationParameters
   {
      private ConvergenceLimits itemField;
      private string versionField;
      private decimal timestepField;
      private bool timestepFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ConvergenceLimits")]
      public ConvergenceLimits Item
      {
         get
         {
            return this.itemField;
         }
         set
         {
            this.itemField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string version
      {
         get
         {
            return this.versionField;
         }
         set
         {
            this.versionField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public decimal timestep
      {
         get
         {
            return this.timestepField;
         }
         set
         {
            this.timestepField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool timestepSpecified
      {
         get
         {
            return this.timestepFieldSpecified;
         }
         set
         {
            this.timestepFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ConvergenceLimits
   {
      private string minimumSystemTimeStepField;
      private string maximumHVACIterationsField;
      private string minimumPlantIterationsField;
      private string maximumPlantIterationsField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
      public string minimumSystemTimeStep
      {
         get
         {
            return this.minimumSystemTimeStepField;
         }
         set
         {
            this.minimumSystemTimeStepField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
      public string maximumHVACIterations
      {
         get
         {
            return this.maximumHVACIterationsField;
         }
         set
         {
            this.maximumHVACIterationsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
      public string minimumPlantIterations
      {
         get
         {
            return this.minimumPlantIterationsField;
         }
         set
         {
            this.minimumPlantIterationsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
      public string maximumPlantIterations
      {
         get
         {
            return this.maximumPlantIterationsField;
         }
         set
         {
            this.maximumPlantIterationsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Weather
   {
      private object[] itemsField;
      private ItemsChoiceType33[] itemsElementNameField;
      private string idField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CDD", typeof(CDD))]
      [System.Xml.Serialization.XmlElementAttribute("City", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Country", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("DDDBCool", typeof(DDDBCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDDBHeat", typeof(DDDBHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDDBRangeCool", typeof(DDDBRangeCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDDBRangeHeat", typeof(DDDBRangeHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDDayCool", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDDayHeat", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDDaylightCool", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDDaylightHeat", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDGroundTCool", typeof(DDGroundTCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDGroundTHeat", typeof(DDGroundTHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDHiHrCool", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("DDHiHrHeat", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("DDLoHrCool", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("DDLoHrHeat", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("DDMonthCool", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDMonthHeat", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDPressureCool", typeof(DDPressureCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDPressureHeat", typeof(DDPressureHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDRainCool", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDRainHeat", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDSkyClearnessCool", typeof(DDSkyClearnessCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDSkyClearnessHeat", typeof(DDSkyClearnessHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDSnowCool", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDSnowHeat", typeof(string), DataType="integer")]
      [System.Xml.Serialization.XmlElementAttribute("DDWBCool", typeof(DDWBCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDWBHeat", typeof(DDWBHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDWindDirCool", typeof(DDWindDirCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDWindDirHeat", typeof(DDWindDirHeat))]
      [System.Xml.Serialization.XmlElementAttribute("DDWindSpeedCool", typeof(DDWindSpeedCool))]
      [System.Xml.Serialization.XmlElementAttribute("DDWindSpeedHeat", typeof(DDWindSpeedHeat))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("GroundTemp", typeof(GroundTemp))]
      [System.Xml.Serialization.XmlElementAttribute("HDD", typeof(HDD))]
      [System.Xml.Serialization.XmlElementAttribute("Location", typeof(Location))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("StateOrProvince", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("WFTDPressure", typeof(WFTDPressure))]
      [System.Xml.Serialization.XmlElementAttribute("WFTDRelHumidity", typeof(WFTDRelHumidity))]
      [System.Xml.Serialization.XmlElementAttribute("WFTDTemp", typeof(WFTDTemp))]
      [System.Xml.Serialization.XmlElementAttribute("WFTDWindDir", typeof(WFTDWindDir))]
      [System.Xml.Serialization.XmlElementAttribute("WFTDWindSpeed", typeof(WFTDWindSpeed))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType33[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class CDD
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("CDDValue", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Temperature", typeof(Temperature))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDDBCool
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDDBHeat
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDDBRangeCool
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDDBRangeHeat
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDGroundTCool
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDGroundTHeat
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDPressureCool
   {
      private pressureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public pressureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDPressureHeat
   {
      private pressureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public pressureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDSkyClearnessCool
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDSkyClearnessHeat
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDWBCool
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDWBHeat
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDWindDirCool
   {
      private directionUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public directionUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDWindDirHeat
   {
      private directionUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public directionUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDWindSpeedCool
   {
      private velocityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public velocityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DDWindSpeedHeat
   {
      private velocityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public velocityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class GroundTemp
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class HDD
   {
      private object[] itemsField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("HDDValue", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Temperature", typeof(Temperature))]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WFTDPressure
   {
      private pressureUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public pressureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WFTDRelHumidity
   {
      private unitlessUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public unitlessUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WFTDTemp
   {
      private temperatureUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WFTDWindDir
   {
      private directionUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public directionUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WFTDWindSpeed
   {
      private velocityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public velocityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType33
   {
      /// <remarks/>
      CDD,
      /// <remarks/>
      City,
      /// <remarks/>
      Country,
      /// <remarks/>
      DDDBCool,
      /// <remarks/>
      DDDBHeat,
      /// <remarks/>
      DDDBRangeCool,
      /// <remarks/>
      DDDBRangeHeat,
      /// <remarks/>
      DDDayCool,
      /// <remarks/>
      DDDayHeat,
      /// <remarks/>
      DDDaylightCool,
      /// <remarks/>
      DDDaylightHeat,
      /// <remarks/>
      DDGroundTCool,
      /// <remarks/>
      DDGroundTHeat,
      /// <remarks/>
      DDHiHrCool,
      /// <remarks/>
      DDHiHrHeat,
      /// <remarks/>
      DDLoHrCool,
      /// <remarks/>
      DDLoHrHeat,
      /// <remarks/>
      DDMonthCool,
      /// <remarks/>
      DDMonthHeat,
      /// <remarks/>
      DDPressureCool,
      /// <remarks/>
      DDPressureHeat,
      /// <remarks/>
      DDRainCool,
      /// <remarks/>
      DDRainHeat,
      /// <remarks/>
      DDSkyClearnessCool,
      /// <remarks/>
      DDSkyClearnessHeat,
      /// <remarks/>
      DDSnowCool,
      /// <remarks/>
      DDSnowHeat,
      /// <remarks/>
      DDWBCool,
      /// <remarks/>
      DDWBHeat,
      /// <remarks/>
      DDWindDirCool,
      /// <remarks/>
      DDWindDirHeat,
      /// <remarks/>
      DDWindSpeedCool,
      /// <remarks/>
      DDWindSpeedHeat,
      /// <remarks/>
      Description,
      /// <remarks/>
      GroundTemp,
      /// <remarks/>
      HDD,
      /// <remarks/>
      Location,
      /// <remarks/>
      Name,
      /// <remarks/>
      Reference,
      /// <remarks/>
      StateOrProvince,
      /// <remarks/>
      WFTDPressure,
      /// <remarks/>
      WFTDRelHumidity,
      /// <remarks/>
      WFTDTemp,
      /// <remarks/>
      WFTDWindDir,
      /// <remarks/>
      WFTDWindSpeed,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WeekSchedule
   {
      private object[] itemsField;
      private ItemsChoiceType20[] itemsElementNameField;
      private string idField;
      private scheduleTypeEnum scheduleTypeField;
      private string scheduleTypeLimitsIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Day", typeof(Day))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType20[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public scheduleTypeEnum scheduleType
      {
         get
         {
            return this.scheduleTypeField;
         }
         set
         {
            this.scheduleTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string scheduleTypeLimitsId
      {
         get
         {
            return this.scheduleTypeLimitsIdField;
         }
         set
         {
            this.scheduleTypeLimitsIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Day
   {
      private string dayScheduleIdRefField;
      private dayTypeEnum dayTypeField;
      private string valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string dayScheduleIdRef
      {
         get
         {
            return this.dayScheduleIdRefField;
         }
         set
         {
            this.dayScheduleIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public dayTypeEnum dayType
      {
         get
         {
            return this.dayTypeField;
         }
         set
         {
            this.dayTypeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public string Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType20
   {
      /// <remarks/>
      Day,
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class WindowType
   {
      private object[] itemsField;
      private ItemsChoiceType17[] itemsElementNameField;
      private string idField;
      private string dOELibIdRefField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Blind", typeof(Blind))]
      [System.Xml.Serialization.XmlElementAttribute("Cost", typeof(Cost))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("ExtEquipId", typeof(ExtEquipId))]
      [System.Xml.Serialization.XmlElementAttribute("Frame", typeof(Frame))]
      [System.Xml.Serialization.XmlElementAttribute("Gap", typeof(Gap))]
      [System.Xml.Serialization.XmlElementAttribute("Glaze", typeof(Glaze))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      [System.Xml.Serialization.XmlElementAttribute("ShadingCoeff", typeof(ShadingCoeff))]
      [System.Xml.Serialization.XmlElementAttribute("SolarHeatGainCoeff", typeof(SolarHeatGainCoeff))]
      [System.Xml.Serialization.XmlElementAttribute("Transmittance", typeof(Transmittance))]
      [System.Xml.Serialization.XmlElementAttribute("U-value", typeof(Uvalue))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType17[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Blind
   {
      private object[] itemsField;
      private ItemsChoiceType13[] itemsElementNameField;
      private string idField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Conductivity", typeof(Conductivity))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      [System.Xml.Serialization.XmlElementAttribute("Thickness", typeof(Thickness))]
      [System.Xml.Serialization.XmlElementAttribute("Transmittance", typeof(Transmittance))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType13[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType13
   {
      /// <remarks/>
      Conductivity,
      /// <remarks/>
      Description,
      /// <remarks/>
      Emittance,
      /// <remarks/>
      Name,
      /// <remarks/>
      Reflectance,
      /// <remarks/>
      Thickness,
      /// <remarks/>
      Transmittance,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Frame
   {
      private object[] itemsField;
      private ItemsChoiceType14[] itemsElementNameField;
      private string idField;
      private frameTypeEnum typeField;
      private string dOELibIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Width", typeof(Width))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType14[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public frameTypeEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType14
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      Width,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Gap
   {
      private object[] itemsField;
      private ItemsChoiceType15[] itemsElementNameField;
      private string idField;
      private gasTypeEnum gasField;
      private string dOELibIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Conductivity", typeof(Conductivity))]
      [System.Xml.Serialization.XmlElementAttribute("ConductivityFofT", typeof(ConductivityFofT))]
      [System.Xml.Serialization.XmlElementAttribute("Density", typeof(Density))]
      [System.Xml.Serialization.XmlElementAttribute("DensityFofT", typeof(DensityFofT))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("PrandtlNumber", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("PrandtlNumberFofT", typeof(PrandtlNumberFofT))]
      [System.Xml.Serialization.XmlElementAttribute("Thickness", typeof(Thickness))]
      [System.Xml.Serialization.XmlElementAttribute("Viscosity", typeof(Viscosity))]
      [System.Xml.Serialization.XmlElementAttribute("ViscosityFofT", typeof(ViscosityFofT))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType15[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public gasTypeEnum gas
      {
         get
         {
            return this.gasField;
         }
         set
         {
            this.gasField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ConductivityFofT
   {
      private conductivityFofTUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public conductivityFofTUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DensityFofT
   {
      private densityFofTUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public densityFofTUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class PrandtlNumberFofT
   {
      private inverseTempUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public inverseTempUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Viscosity
   {
      private viscosityUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public viscosityUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ViscosityFofT
   {
      private viscosityFofTUnitEnum unitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public viscosityFofTUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType15
   {
      /// <remarks/>
      Conductivity,
      /// <remarks/>
      ConductivityFofT,
      /// <remarks/>
      Density,
      /// <remarks/>
      DensityFofT,
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
      /// <remarks/>
      PrandtlNumber,
      /// <remarks/>
      PrandtlNumberFofT,
      /// <remarks/>
      Thickness,
      /// <remarks/>
      Viscosity,
      /// <remarks/>
      ViscosityFofT,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Glaze
   {
      private object[] itemsField;
      private ItemsChoiceType16[] itemsElementNameField;
      private string idField;
      private string dOELibIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Conductivity", typeof(Conductivity))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Emittance", typeof(Emittance))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reference", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Reflectance", typeof(Reflectance))]
      [System.Xml.Serialization.XmlElementAttribute("Thickness", typeof(Thickness))]
      [System.Xml.Serialization.XmlElementAttribute("Transmittance", typeof(Transmittance))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType16[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string DOELibIdRef
      {
         get
         {
            return this.dOELibIdRefField;
         }
         set
         {
            this.dOELibIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType16
   {
      /// <remarks/>
      Conductivity,
      /// <remarks/>
      Description,
      /// <remarks/>
      Emittance,
      /// <remarks/>
      Name,
      /// <remarks/>
      Reference,
      /// <remarks/>
      Reflectance,
      /// <remarks/>
      Thickness,
      /// <remarks/>
      Transmittance,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType17
   {
      /// <remarks/>
      Blind,
      /// <remarks/>
      Cost,
      /// <remarks/>
      Description,
      /// <remarks/>
      Emittance,
      /// <remarks/>
      ExtEquipId,
      /// <remarks/>
      Frame,
      /// <remarks/>
      Gap,
      /// <remarks/>
      Glaze,
      /// <remarks/>
      Name,
      /// <remarks/>
      Reflectance,
      /// <remarks/>
      ShadingCoeff,
      /// <remarks/>
      SolarHeatGainCoeff,
      /// <remarks/>
      Transmittance,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("U-value")]
      Uvalue,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Zone
   {
      private object[] itemsField;
      private ItemsChoiceType22[] itemsElementNameField;
      private string idField;
      private string heatSchedIdRefField;
      private string coolSchedIdRefField;
      private string outAirSchedIdRefField;
      private string airChangesSchedIdRefField;
      private string fanSchedIdRefField;
      private string fanTempSchedIdRefField;
      private string ifcGUIDField;
      private string programIdField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("AirChangesPerHour", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("AirLoopId", typeof(AirLoopId))]
      [System.Xml.Serialization.XmlElementAttribute("BaseboardHeatingCapacity", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("BaseboardHeatingType", typeof(BaseboardHeatingType))]
      [System.Xml.Serialization.XmlElementAttribute("CADObjectId", typeof(CADObjectId))]
      [System.Xml.Serialization.XmlElementAttribute("CoolingSizingFactor", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("DesignCoolT", typeof(DesignCoolT))]
      [System.Xml.Serialization.XmlElementAttribute("DesignHeatT", typeof(DesignHeatT))]
      [System.Xml.Serialization.XmlElementAttribute("Flow", typeof(Flow))]
      [System.Xml.Serialization.XmlElementAttribute("FlowPerArea", typeof(FlowPerArea))]
      [System.Xml.Serialization.XmlElementAttribute("FlowPerPerson", typeof(FlowPerPerson))]
      [System.Xml.Serialization.XmlElementAttribute("HeatingSizingFactor", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("HydronicLoopId", typeof(HydronicLoopId))]
      [System.Xml.Serialization.XmlElementAttribute("IndoorAirQuality", typeof(IndoorAirQuality))]
      [System.Xml.Serialization.XmlElementAttribute("MaxOAFlowPerZone", typeof(MaxOAFlowPerZone))]
      [System.Xml.Serialization.XmlElementAttribute("MinOAFlowPerZone", typeof(MinOAFlowPerZone))]
      [System.Xml.Serialization.XmlElementAttribute("MinimumOutdoorAirControlType", typeof(MinimumOutdoorAirControlType))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("OAFlowPerArea", typeof(OAFlowPerArea))]
      [System.Xml.Serialization.XmlElementAttribute("OAFlowPerPerson", typeof(OAFlowPerPerson))]
      [System.Xml.Serialization.XmlElementAttribute("OAFlowPerZone", typeof(OAFlowPerZone))]
      [System.Xml.Serialization.XmlElementAttribute("SecondaryFlow", typeof(SecondaryFlow))]
      [System.Xml.Serialization.XmlElementAttribute("TypeCode", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public object[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType22[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string heatSchedIdRef
      {
         get
         {
            return this.heatSchedIdRefField;
         }
         set
         {
            this.heatSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string coolSchedIdRef
      {
         get
         {
            return this.coolSchedIdRefField;
         }
         set
         {
            this.coolSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string outAirSchedIdRef
      {
         get
         {
            return this.outAirSchedIdRefField;
         }
         set
         {
            this.outAirSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string airChangesSchedIdRef
      {
         get
         {
            return this.airChangesSchedIdRefField;
         }
         set
         {
            this.airChangesSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string fanSchedIdRef
      {
         get
         {
            return this.fanSchedIdRefField;
         }
         set
         {
            this.fanSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string fanTempSchedIdRef
      {
         get
         {
            return this.fanTempSchedIdRefField;
         }
         set
         {
            this.fanTempSchedIdRefField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string ifcGUID
      {
         get
         {
            return this.ifcGUIDField;
         }
         set
         {
            this.ifcGUIDField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class BaseboardHeatingType
   {
      private baseboardHeatingTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public baseboardHeatingTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class DesignHeatT
   {
      private temperatureUnitEnum unitField;
      private bool unitFieldSpecified;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public temperatureUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class Flow
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FlowPerArea
   {
      private flowPerAreaUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowPerAreaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class FlowPerPerson
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MaxOAFlowPerZone
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinOAFlowPerZone
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class MinimumOutdoorAirControlType
   {
      private minimumOutdoorAirControlTypeEnum unitField;
      private bool unitFieldSpecified;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public minimumOutdoorAirControlTypeEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public bool unitSpecified
      {
         get
         {
            return this.unitFieldSpecified;
         }
         set
         {
            this.unitFieldSpecified = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class OAFlowPerArea
   {
      private flowPerAreaUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowPerAreaUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class OAFlowPerPerson
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class OAFlowPerZone
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class SecondaryFlow
   {
      private flowUnitEnum unitField;
      private string programIdField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public flowUnitEnum unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string programId
      {
         get
         {
            return this.programIdField;
         }
         set
         {
            this.programIdField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType22
   {
      /// <remarks/>
      AirChangesPerHour,
      /// <remarks/>
      AirLoopId,
      /// <remarks/>
      BaseboardHeatingCapacity,
      /// <remarks/>
      BaseboardHeatingType,
      /// <remarks/>
      CADObjectId,
      /// <remarks/>
      CoolingSizingFactor,
      /// <remarks/>
      Description,
      /// <remarks/>
      DesignCoolT,
      /// <remarks/>
      DesignHeatT,
      /// <remarks/>
      Flow,
      /// <remarks/>
      FlowPerArea,
      /// <remarks/>
      FlowPerPerson,
      /// <remarks/>
      HeatingSizingFactor,
      /// <remarks/>
      HydronicLoopId,
      /// <remarks/>
      IndoorAirQuality,
      /// <remarks/>
      MaxOAFlowPerZone,
      /// <remarks/>
      MinOAFlowPerZone,
      /// <remarks/>
      MinimumOutdoorAirControlType,
      /// <remarks/>
      Name,
      /// <remarks/>
      OAFlowPerArea,
      /// <remarks/>
      OAFlowPerPerson,
      /// <remarks/>
      OAFlowPerZone,
      /// <remarks/>
      SecondaryFlow,
      /// <remarks/>
      TypeCode,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   public enum gbXMLEngine
   {
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("DOE2.1e")]
      DOE21e,
      /// <remarks/>
      [System.Xml.Serialization.XmlEnumAttribute("DOE2.2")]
      DOE22,
      /// <remarks/>
      EnergyPlus,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class GapId
   {
      private string gapIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string gapIdRef
      {
         get
         {
            return this.gapIdRefField;
         }
         set
         {
            this.gapIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class GlazeId
   {
      private string glazeIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string glazeIdRef
      {
         get
         {
            return this.glazeIdRefField;
         }
         set
         {
            this.glazeIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class LightId
   {
      private string lightIdRefField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
      public string lightIdRef
      {
         get
         {
            return this.lightIdRefField;
         }
         set
         {
            this.lightIdRefField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class ScheduleTypeLimits
   {
      private decimal[] itemsField;
      private ItemsChoiceType39[] itemsElementNameField;
      private string idField;
      private scheduleTypeLimitsEnum typeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("LowerLimitValue", typeof(decimal))]
      [System.Xml.Serialization.XmlElementAttribute("UpperLimitValue", typeof(decimal))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public decimal[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType39[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
      public string id
      {
         get
         {
            return this.idField;
         }
         set
         {
            this.idField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public scheduleTypeLimitsEnum type
      {
         get
         {
            return this.typeField;
         }
         set
         {
            this.typeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType39
   {
      /// <remarks/>
      LowerLimitValue,
      /// <remarks/>
      UpperLimitValue,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class TimeIncrement
   {
      private timeUnitEnum timeUnitField;
      private decimal valueField;
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public timeUnitEnum timeUnit
      {
         get
         {
            return this.timeUnitField;
         }
         set
         {
            this.timeUnitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlTextAttribute()]
      public decimal Value
      {
         get
         {
            return this.valueField;
         }
         set
         {
            this.valueField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class XAxis
   {
      private string[] itemsField;
      private ItemsChoiceType40[] itemsElementNameField;
      private string unitField;
      private string dataTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType40[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string dataType
      {
         get
         {
            return this.dataTypeField;
         }
         set
         {
            this.dataTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType40
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Diagnostics.DebuggerStepThroughAttribute()]
   [System.ComponentModel.DesignerCategoryAttribute("code")]
   [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.gbxml.org/schema")]
   [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.gbxml.org/schema", IsNullable=false)]
   public partial class YAxis
   {
      private string[] itemsField;
      private ItemsChoiceType41[] itemsElementNameField;
      private string unitField;
      private string dataTypeField;
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
      [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
      [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
      public string[] Items
      {
         get
         {
            return this.itemsField;
         }
         set
         {
            this.itemsField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
      [System.Xml.Serialization.XmlIgnoreAttribute()]
      public ItemsChoiceType41[] ItemsElementName
      {
         get
         {
            return this.itemsElementNameField;
         }
         set
         {
            this.itemsElementNameField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string unit
      {
         get
         {
            return this.unitField;
         }
         set
         {
            this.unitField = value;
         }
      }
      /// <remarks/>
      [System.Xml.Serialization.XmlAttributeAttribute()]
      public string dataType
      {
         get
         {
            return this.dataTypeField;
         }
         set
         {
            this.dataTypeField = value;
         }
      }
   }
   /// <remarks/>
   [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
   [System.SerializableAttribute()]
   [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.gbxml.org/schema", IncludeInSchema=false)]
   public enum ItemsChoiceType41
   {
      /// <remarks/>
      Description,
      /// <remarks/>
      Name,
   }
}
