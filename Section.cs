using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261027_w05
{
    class Section
    {
        private string sectionDate;
        private string sectionTimeS;
        private string sectionTimeE;
        private Room sectionRoom;
        private Subject sectionSubject;
        private Lecturer sectionLecturer;

        public string SectionDate
        {
            get { return this.sectionDate; }
            set { this.sectionDate = value; }
        }

        public string SectionTimeS
        {
            get { return this.sectionTimeS; }
            set { this.sectionTimeS = value; }
        }
        public string SectionTimeE
        {
            get { return this.sectionTimeE; }
            set { this.sectionTimeE = value; }
        }
        public Room SectionRoom
        {
            get { return this.sectionRoom; }
            set { this.sectionRoom = value; }
        }
        public Subject SectionSubject
        {
            get { return this.sectionSubject; }
            set { this.sectionSubject = value; }
        }
        public Lecturer SectionLecturer
        {
            get { return this.sectionLecturer; }
            set { this.sectionLecturer = value; }
        }
        public Section() { }
        public Section(string sd, string sts, string ste, Room sr, Subject ss, Lecturer sl)
        {
            this.SectionDate = sd;
            this.SectionTimeS = sts;
            this.SectionTimeE = ste;
            this.SectionRoom = sr;
            this.SectionSubject = ss;
            this.SectionLecturer = sl;
        }
        public override string ToString()
        {
            return " Room " + this.SectionRoom.RoomCode + " " + " Subject " 
                + this.SectionSubject.SubjectName +" " + " Lecturer " + this.SectionLecturer.LecturerFName + " " 
                + this.SectionLecturer.LecturerLName
                + " Date " + this.SectionDate + " Start " + this.SectionTimeS + " End " + this.SectionTimeE ;
        }
    }
}
