﻿using Revitalize.Aesthetics;
using Revitalize.Aesthetics.WeatherDebris;
using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revitalize.Resources
{
    class Lists
    {
      public static  List<Revitalize.Resources.DataNodes.TrackedTerrainDataNode> trackedTerrainFeatures;
        public static List<Revitalize.Resources.DataNodes.TrackedTerrainDummyDataNode> trackedTerrainFeaturesDummyList;

        public static List<Revitalize.CoreObject> trackedObjectList;

  

        public static void initializeAllLists()
        {
            trackedTerrainFeatures = new List<DataNodes.TrackedTerrainDataNode>();
            trackedTerrainFeaturesDummyList = new List<DataNodes.TrackedTerrainDummyDataNode>();
            trackedObjectList = new List<CoreObject>();
            WeatherDebrisSystem.thisWeatherDebris = new List<WeatherDebrisPlus>();
        }

        public static void loadAllLists()
        {
            Serialize.parseTrackedTerrainDataNodeList(Path.Combine( Serialize.PlayerDataPath ,"TrackedTerrainFeaturesList.json"));
              
            Class1.hasLoadedTerrainList = true;
          //  Log.AsyncC(Path.Combine(Serialize.PlayerDataPath, "TrackedTerrainFeaturesList.json"));
        }
    }
}