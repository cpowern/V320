using System.Dynamic;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            History history = new History();

            editor.Content = "Hallo";


            var state = editor.CreateState();
            history.Push(state);
            editor.Content = "Hallo Welt";


            state = editor.CreateState();
            history.Push(state);
            editor.Content = "Hello World";

            editor.RestoreState(history.Pop());
            editor.RestoreState(history.Pop());

            Console.WriteLine(editor.Content);

            Console.ReadLine();
            //editor.Undo();
        }
    }

    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            var state = new EditorState();
            state.Content = Content;
            return state;
        }

        public void RestoreState(EditorState state)
        {
            this.Content = state.Content;
        }
    }

    public class EditorState
    {
        public string Content { get; set; }
    }

    public class History
    {
        private Stack<EditorState> editorStates = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            editorStates.Push(state);
        }

        public EditorState Pop()
        {
            return editorStates.Pop();
        }
    }
}