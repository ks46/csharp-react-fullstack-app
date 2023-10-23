﻿using courses.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace courses.wwwapi.EndPoints
{
    public static class CoursesDeclarationApi
    {
        public static void ConfigureCoursesDeclarationApi(this WebApplication app)
        {
            app.MapGet("/students/{studentId}", GetStudent);
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
            throw new NotImplementedException();
        }


        /// <summary>
        /// Create a new declaration for a particular student
        /// </summary>
        /// <returns>
        /// Status 201 - Ticket object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostDeclaration(int studentId, IRepository service)
        {
            throw new NotImplementedException();
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
