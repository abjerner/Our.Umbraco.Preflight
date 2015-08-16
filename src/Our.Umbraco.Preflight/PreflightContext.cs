using Our.Umbraco.Preflight.Groups;

namespace Our.Umbraco.Preflight {

    public class PreflightContext {

        #region Private fields

        private readonly PreflightGroupCollection _groups = new PreflightGroupCollection();

        #endregion

        #region Properties

        /// <summary>
        /// Gets the singleton instance of the <code>PreflightContext</code> class.
        /// </summary>
        public static readonly PreflightContext Current = new PreflightContext();

        public PreflightGroupCollection Groups {
            get { return _groups; }
        }
        
        #endregion

        #region Constructors

        private PreflightContext() { }

        #endregion

    }

}