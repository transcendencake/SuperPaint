using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.Figures;
using SuperPaint.Actions;
using System.Reflection;

namespace SuperPaint.Utils
{
    internal static class Storage
    {
        public static List<Figure> AllFigures;
        private static Stack<IFigureAction> doneActions;
        private static Stack<IFigureAction> undoneActions;

        static Storage()
        {
            AllFigures = new List<Figure>();
            doneActions = new Stack<IFigureAction>();
            undoneActions = new Stack<IFigureAction>();
        }
        public static bool Undo()
        {
            if (doneActions.Count == 0) return false;
            IFigureAction action = doneActions.Pop();
            action.Undo();
            undoneActions.Push(action);
            return true;
        }
        public static bool Redo()
        {
            if (undoneActions.Count == 0) return false;
            IFigureAction action = undoneActions.Pop();
            action.Redo();
            doneActions.Push(action);
            return true;
        }
        public static void AddAction(IFigureAction action)
        {
            doneActions.Push(action);
            undoneActions.Clear();
        }
        public static void Clear()
        {
            AllFigures.Clear();
            doneActions.Clear();
            undoneActions.Clear();
        }
    }
}
