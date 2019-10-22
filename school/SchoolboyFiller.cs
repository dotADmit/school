using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    enum SchoolboyStatus
    {
        Best,
        Good,
        Middle,
        Bad
    }
    struct MarkGeneratorSettings
    {
        public int ProbabilityAn5Mark;
        public int ProbabilityAn4Mark;
        public int ProbabilityAn3Mark;
        public int ProbabilityAn2Mark;
    }


    class SchoolboyFiller
    {
        private Random _rnd = new Random();
        public string GetRandomFullName()
        {
            string[] surName = new string[] { "Иванов", "Петров", "Сидоров", "Соколов", "Каплунов" };
            string[] name = new string[] { "Сергей", "Иван", "Антон", "Дмитрий", "Константин" };
            string[] patronymic = new string[] { "Филиппович", "Геннадьевич", "Архипович", "Фёдорович", "Спиридонович" };

            return surName[_rnd.Next(0, 5)] + " " + name[_rnd.Next(0, 5)] + " " + patronymic[_rnd.Next(0, 5)];
        }
        public SchoolboyStatus GetRandomStatus()
        {
            return (SchoolboyStatus)_rnd.Next(0, 4);
        }
        public MarkGeneratorSettings GetRandomMarkSettings(SchoolboyStatus status)
        {
            MarkGeneratorSettings markGeneratorSettings = new MarkGeneratorSettings();
            switch (status)
            {

                case SchoolboyStatus.Best:
                    {
                        markGeneratorSettings.ProbabilityAn4Mark = _rnd.Next(5, 16);
                        markGeneratorSettings.ProbabilityAn3Mark = _rnd.Next(5, 11);
                        markGeneratorSettings.ProbabilityAn2Mark = _rnd.Next(0, 6);
                        markGeneratorSettings.ProbabilityAn5Mark = 100 - markGeneratorSettings.ProbabilityAn4Mark - markGeneratorSettings.ProbabilityAn3Mark - markGeneratorSettings.ProbabilityAn2Mark;
                        break;
                    }
                case SchoolboyStatus.Good:
                    {
                        markGeneratorSettings.ProbabilityAn5Mark = _rnd.Next(5, 16);
                        markGeneratorSettings.ProbabilityAn3Mark = _rnd.Next(5, 16);
                        markGeneratorSettings.ProbabilityAn2Mark = _rnd.Next(0, 6);
                        markGeneratorSettings.ProbabilityAn4Mark = 100 - markGeneratorSettings.ProbabilityAn5Mark - markGeneratorSettings.ProbabilityAn3Mark - markGeneratorSettings.ProbabilityAn2Mark;
                        break;
                    }
                case SchoolboyStatus.Middle:
                    {
                        markGeneratorSettings.ProbabilityAn5Mark = _rnd.Next(0, 11);
                        markGeneratorSettings.ProbabilityAn4Mark = _rnd.Next(10, 21);
                        markGeneratorSettings.ProbabilityAn2Mark = _rnd.Next(5, 21);
                        markGeneratorSettings.ProbabilityAn3Mark = 100 - markGeneratorSettings.ProbabilityAn5Mark - markGeneratorSettings.ProbabilityAn4Mark - markGeneratorSettings.ProbabilityAn2Mark;
                        break;
                    }
                case SchoolboyStatus.Bad:
                    {
                        markGeneratorSettings.ProbabilityAn5Mark = _rnd.Next(0, 6);
                        markGeneratorSettings.ProbabilityAn4Mark = _rnd.Next(5, 11);
                        markGeneratorSettings.ProbabilityAn3Mark = _rnd.Next(10, 21);
                        markGeneratorSettings.ProbabilityAn2Mark = 100 - markGeneratorSettings.ProbabilityAn5Mark - markGeneratorSettings.ProbabilityAn4Mark - markGeneratorSettings.ProbabilityAn3Mark;
                        break;
                    }
            }
            return markGeneratorSettings;
        }
    }
}
