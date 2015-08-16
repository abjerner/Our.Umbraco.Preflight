using System.Collections.Generic;
using Newtonsoft.Json;
using Our.Umbraco.Preflight.Checks;

namespace Our.Umbraco.Preflight.Groups {

    public class PreflightGroup {

        #region Private Fields

        private readonly List<ICheck> _checks = new List<ICheck>();

        #endregion

        #region Properties

        [JsonProperty("alias")]
        public string Alias { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("checks")]
        public List<ICheck> Checks {
            get { return _checks; }
        }

        #endregion

        #region Constructors

        public PreflightGroup(string name) {
            Name = name;
            Alias = name.Replace(" ", "");
        }

        public PreflightGroup(string name, string alias) {
            Name = name;
            Alias = alias;
        }

        #endregion

    }

}