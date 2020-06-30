using Esri.ArcGISRuntime.Mapping;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CreateMapWithLayer
{
    /// <summary>
    /// Provides map data to an application
    /// </summary>
    public class MapViewModel : INotifyPropertyChanged
    {
        public MapViewModel()
        {
            CreateNewMap();
        }

        /// <summary>
        /// Create a Map with an imagery basemap and the Los Angeles Trailheads layer
        /// </summary>
        private async void CreateNewMap()
        {
            // Create a new Map, use a static method on the Basemap class to define the basemap
            Map newMap = new Map(Basemap.CreateImageryWithLabels());

            // Create a new FeatureLayer, set the data source with the URI to the LA Trailheads layer
            FeatureLayer trailHeadsLayer = new FeatureLayer(new Uri("https://services3.arcgis.com/GVgbJbqm8hXASVYi/arcgis/rest/services/Trailheads/FeatureServer/0"));

            // Load the trailheads layer so the FullExtent property is populated (will need it)
            await trailHeadsLayer.LoadAsync();

            // Add the FeatureLayer to the OperationalLayers collection
            newMap.OperationalLayers.Add(trailHeadsLayer);

            // Set the map's initial area of interest to the extent of all features in the trailheads layer
            newMap.InitialViewpoint = new Viewpoint(trailHeadsLayer.FullExtent);
            
            // Set the MapViewModel's Map property with the new map
            Map = newMap;
        }

        private Map _map = new Map(Basemap.CreateStreetsVector());

        /// <summary>
        /// Gets or sets the map
        /// </summary>
        public Map Map
        {
            get { return _map; }
            set { _map = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Raises the <see cref="MapViewModel.PropertyChanged" /> event
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var propertyChangedHandler = PropertyChanged;
            if (propertyChangedHandler != null)
                propertyChangedHandler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}