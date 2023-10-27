using courses.wwwapi.Models;
using courses.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace courses.wwwapi.EndPoints
{
    public static class CoursesDeclarationApi
    {
        public static void ConfigureCoursesDeclarationApi(this WebApplication app)
        {
            app.MapGet("/students/{studentId}", GetStudent);
            app.MapGet("/students/{studentId}/courses", GetCourses);
            app.MapPost("/students/{studentId}/declarations", PostDeclaration);
            app.MapGet("/students/{studentId}/declarations/{declarationId}", GetDeclaration);
        }


        /// <summary>
        /// Get info for student with id studentId
        /// </summary>
        /// <returns>
        /// Status 200 - Student object
        /// Status 404 - Student with such studentId does not exist
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetStudent(int studentId, IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Student? student = service.GetStudent(studentId);
                    if (student == null)
                        return Results.NotFound();
                    return Results.Ok(student);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        /// <summary>
        /// Get all courses for student with such studentId
        /// </summary>
        /// <returns>
        /// Status 200 - List of Course objects
        /// Status 404 - Student with such studentId does not exist
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCourses(int studentId, IRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    IEnumerable<Course> courses = service.GetCourses(studentId);
                    if (courses == null)
                        return Results.NotFound();
                    return Results.Ok(courses);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        /// <summary>
        /// Create a new declaration for a particular student
        /// </summary>
        /// <returns>
        /// Status 201 - CoursesDeclaration object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostDeclaration(int studentId, IEnumerable<int> courseIds, IRepository service)
        {
            throw new NotImplementedException();
            try
            {
                return await Task.Run(() =>
                {
                    DateTime dt = DateTime.UtcNow;
                    Declaration decl = new Declaration()
                    {
                        studentId = studentId,
                        period = "Winter 2023",
                        createdAt = dt,
                        updatedAt = dt
                    };


                    return Results.Ok();
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }


        /// <summary>
        /// Get info for courses declaration with declarationId for student with studentId
        /// </summary>
        /// <returns>
        /// Status 200 - All info for a particular courses declaration
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetDeclaration(int studentId, int declarationId, IRepository service)
        {
            throw new NotImplementedException();
        }
    }
}
