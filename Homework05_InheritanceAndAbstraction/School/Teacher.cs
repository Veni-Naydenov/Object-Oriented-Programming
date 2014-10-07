namespace School
{
    using System.Collections.Generic;
    using System.Text;

    class Teacher : People
    {
        private IList<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines, string details = null)
        {
            base.Name = name;
            this.disciplines = disciplines;
            base.Details = details;
        }

        public IList<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                this.disciplines = value;
            }
        }

        public override string ToString()
        {
            var allDisciplines = new StringBuilder();
            var allDisciplinesNames = new StringBuilder();

            foreach (var discip in disciplines)
            {
                allDisciplinesNames.AppendFormat("{0} /", discip.Name);
                var studentBuilder = new StringBuilder();

                foreach (var st in discip.Students)
                {
                    studentBuilder.AppendFormat("{0}\n", st.ToString());
                }

                allDisciplines.AppendFormat(
                    "Discipline Name: {0}\n" +
                "Number of {0} lectures: {1}\n" +
                "{0} Students:\n{2}\n" +
                "{0} Details: {3}\n", discip.Name,
                discip.CountOfLectures,
                studentBuilder,
                discip.Details);
            }

            string teacherInfo = string.Format(
                "Teacher Name: {0}\nTeacher disciplines: {1}\n" +
            "Teacher Details: {2}\n##### Disciplines info:\n{3}",
                this.Name, allDisciplinesNames, this.Details, allDisciplines);

            return teacherInfo;
        }
    }
}
