using System;
using System.Collections.Generic;
using Umbraco.Core;

namespace Our.Umbraco.Preflight.Checks {

    public class CheckFactory {
        
        public static readonly IList<ICheck> Checks = new List<ICheck>();

        static CheckFactory() {
            RegisterChecks();
        }

        private static void RegisterChecks() {
            var types = TypeFinder.FindClassesOfType<ICheck>();
            foreach (var t in types) {
                var typeInstance = Activator.CreateInstance(t) as ICheck;
                if (typeInstance != null) {
                    Checks.Add(typeInstance);
                }
            }
        }
    
    }

}