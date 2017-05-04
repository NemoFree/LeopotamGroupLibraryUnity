// ----------------------------------------------------------------------------
// The MIT License
// LeopotamGroupLibrary https://github.com/Leopotam/LeopotamGroupLibraryUnity
// Copyright (c) 2012-2017 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;

namespace LeopotamGroup.SystemUi.Actions {
    /// <summary>
    /// Base class for ui action.
    /// </summary>
    public abstract class UiActionBase : MonoBehaviour {
        [SerializeField]
        string _group;

        protected int GroupId { get; private set; }

        protected virtual void Awake () {
            SetGroup (_group);
        }

        public void SetGroup (string group) {
            _group = group;
            GroupId = group != null ? group.GetHashCode () : 0;
        }
    }
}