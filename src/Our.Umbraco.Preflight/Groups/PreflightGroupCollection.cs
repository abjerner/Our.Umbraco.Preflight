using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Our.Umbraco.Preflight.Groups {
    
    public class PreflightGroupCollection : IEnumerable<PreflightGroup> {

        #region Private fields

        private readonly List<PreflightGroup> _groups = new List<PreflightGroup> {
            new PreflightGroup("Umbraco", "umbraco")
        };

        #endregion

        #region Properties

        /// <summary>
        /// Gets the amount of groups added to the collection.
        /// </summary>
        public int Count {
            get { return _groups.Count; }
        }

        /// <summary>
        /// Gets a reference to the underlying list.
        /// </summary>
        public List<PreflightGroup> List {
            get { return _groups; }
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets the first group with the specified <code>alias</code>.
        /// </summary>
        /// <param name="alias">The alias of the group.</param>
        public PreflightGroup GetGroup(string alias) {
            return _groups.FirstOrDefault(x => x.Alias == alias);
        }

        /// <summary>
        /// Gets the first group matching the specified <code>predicate</code>.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        public PreflightGroup GetGroup(Func<PreflightGroup, bool> predicate) {
            return _groups.FirstOrDefault(predicate);
        }

        /// <summary>
        /// Gets whether the collection contains at least one group with the specified <code>alias</code>.
        /// </summary>
        /// <param name="alias">The alias of the group.</param>
        public bool ContainsGroup(string alias) {
            return _groups.Any(x => x.Alias == alias);
        }

        /// <summary>
        /// Gets whether the collection contains at least one group matching the specified <code>predicate</code>.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        public bool ContainsGroup(Func<PreflightGroup, bool> predicate) {
            return _groups.Any(predicate);
        }

        /// <summary>
        /// Adds the specified <code>group</code> to the collection.
        /// </summary>
        /// <param name="group">The group to be added.</param>
        public void Add(PreflightGroup group) {
            _groups.Add(group);
        }

        /// <summary>
        /// Adds the specified <code>group</code> to the collection at <code>index</code>.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="group">The group to be added.</param>
        public void AddAt(int index, PreflightGroup group) {
            _groups.Insert(index, group);
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public void Clear() {
            _groups.Clear();
        }

        /// <summary>
        /// Removes the specified <code>group</code> from the collection.
        /// </summary>
        /// <param name="group">The group to be removed.</param>
        public void Remove(PreflightGroup group) {
            _groups.Remove(group);
        }

        /// <summary>
        /// Removes the group at the specified <code>index</code>.
        /// </summary>
        /// <param name="index">The index of the group to be removed.</param>
        public void RemoveAt(int index) {
            _groups.RemoveAt(index);
        }

        public IEnumerator<PreflightGroup> GetEnumerator() {
            return _groups.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        #endregion

    }

}