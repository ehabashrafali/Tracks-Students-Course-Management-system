﻿using Admin_Panel_ITI.Models;

namespace Admin_Panel_ITI.Repos
{
    public interface ICourseRepository
    {
        public int GetCourseNumber();
        public int GetCourseNumberbyIntakeID(int intakeID);



        public Course GetCoursebyID(int courseID);



        public List<Course> GetCourses();


        public void UpdateCourse(int CourseID, Course course);


        public void DeleteCourse(int courseID);


        public void CreateCourse(Course course);
    }
}