﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CREditor.Utilities
{
    public interface IUndoRedo
    {
        string Name { get; }
        void Undo();
        void Redo();
    }

    public class UndoRedoAction : IUndoRedo
    {
        private Action _undoAction;
        private Action _redoAction;

        public string Name { get; }

        public void Redo() => _redoAction();

        public void Undo() => _undoAction();

        public UndoRedoAction(string name)
        {
            Name = name;
        }

        public UndoRedoAction(Action undo, Action redo, string name) : this(name)
        {
            Debug.Assert(undo != null && redo != null);
            _undoAction = undo;
            _redoAction = redo;
        }
    }

    public class UndoRedo
    {
        private readonly ObservableCollection<UndoRedo> _redoList = new ObservableCollection<UndoRedo>();
        private readonly ObservableCollection<UndoRedo> _undoList = new ObservableCollection<UndoRedo>();
        public ReadOnlyObservableCollection<UndoRedo> RedoList { get; }
        public ReadOnlyObservableCollection<UndoRedo> UndoList { get; }

        public void Reset()
        {
            _redoList.Clear();
            _undoList.Clear();
        }

        public void Add(UndoRedo cmd)
        {
            _undoList.Add(cmd);
            _redoList.Clear();
        }

        /*public void Undo()
        {
            if(_undoList.Any())
            {
                var cmd = _undoList.Last();
                _undoList.RemoveAt(_undoList.Count - 1);
                cmd.Undo();
                _redoList.Insert(0, cmd);
            }
        }

        public void Redo()
        {
            if(_redoList.Any())
            {
                var cmd = _redoList.First();
                _redoList.Remove(0);
                cmd.Redo();
                _undoList.Add(cmd);
            }
        }

        public UndoRedo()
        {
            RedoList = new ReadOnlyObservableCollection<UndoRedo>(_redoList);
            UndoList = new ReadOnlyObservableCollection<UndoRedo>(_undoList);
        }*/
    }
}
