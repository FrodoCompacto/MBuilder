using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MBuilder.Models
{
    class Macro
    {

        public List<InputStatus> Inputs { get; set; }
        public int Precision { get; set; }

        public Macro()
        {

        }

        public Macro(int precision)
        {
            this.Inputs = new List<InputStatus>();
            this.Precision = precision;
        }

        public Macro(int precision, List<InputStatus> inputs)
        {
            this.Inputs = inputs;
            this.Precision = precision;
        }

        public Macro(String Path)
        {
            Macro aux = JsonConvert.DeserializeObject<Macro>(System.IO.File.ReadAllText(Path));

            this.Inputs = aux.Inputs;
            this.Precision = aux.Precision;
        }

        public void addInput(Mouse mouse, Keyboard keyboard)
        {
            if (Inputs.Count == 0)
            {
                Inputs.Add(new InputStatus(mouse, keyboard, 0));
            }
            else
            {
                Inputs.Add(new InputStatus(mouse, keyboard, Precision));
            }
        }


        public void saveMacro(String path)
        {
            int auxDelay = 5;

            List<InputStatus> auxInputs = new List<InputStatus>();
            auxInputs.Add(Inputs[0]);

            for (int i = 1; i < Inputs.Count; i++)
            {
                if (Inputs[i].mouse.Equals(Inputs[i - 1].mouse) && Inputs[i].keyboard.Equals(Inputs[i - 1].keyboard))
                {
                    auxDelay += Precision;
                } else
                {
                    auxInputs.Add(new InputStatus(Inputs[i].mouse, Inputs[i].keyboard, auxDelay));
                    auxDelay = 5;
                }
            }


            var json = JsonConvert.SerializeObject(new Macro(Precision, auxInputs));

            DateTime date = DateTime.Now;

            String filepath = System.IO.Path.Combine(path, date.ToString("MM-dd_Hmm") + ".txt");

            System.IO.File.WriteAllText(filepath, json);
        }

    }
}

