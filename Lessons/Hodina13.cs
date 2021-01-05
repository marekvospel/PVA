using System;
using System.Threading;

namespace PVA.Lessons {
    
    public class Hodina13 {

        public static void Start() {
            
            /*
             * Opakovani
             * Vice o getterech a seterech v hodine 12
             * @see PVA.Lessons.Hodina12
             */

            Button button = new Button();
            button.Text = "Ahoj";
            
            Console.WriteLine(button.Text);
            Console.WriteLine("Edit " + button.LastEdit);
            
            Thread.Sleep(5000);
            button.Text = "Nazdar ";
            Console.WriteLine(button.LastEdit);
            Console.WriteLine("View " + button.LastView);
            Console.WriteLine(button.Text);
            Thread.Sleep(1000);
            Console.WriteLine("View " + button.LastView);

            Button button2 = new Button("Ahooooj");
            Console.WriteLine("Edit " + button2.LastEdit);
            Console.WriteLine(button2.Text);

            Console.WriteLine(button.Id);
            Button button3 = new Button(11);
            Console.WriteLine(button3.Id);
        }
    }

    public class Button {
        public int Id;
        private string _text;
        public DateTime LastView, LastEdit;
        
        public string Text {
            get {
                LastView = DateTime.Now;
                return _text;
            }
            set {
                _text = value;
                LastEdit = DateTime.Now;
            }
        }

        /*
         * Constructoru i metod muze byt kolik chcete, ale musi mit jine parametry
         * (Program musi vedet ktery constructor ma pouzit)
         * ex (int x) a (int y) by nesly, ale (int x) a (double y) by slo
         *
         * Stejne je to s metodami
         */
        public Button() {
            
        }
        
        public Button(string text) {
            _text = text;
            LastEdit = DateTime.Now;
        }

        public Button(int id) {
            Id = id;
        }
    }
}