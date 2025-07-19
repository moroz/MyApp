using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateUUIDv7Function : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = ReadEmbeddedResource("MyApp.Data.Scripts.CreateUUIDv7Function.sql");
            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                drop function if exists uuid7(timestamp with time zone);
                drop function if exists uuid7();
                drop extension if exists pgcrypto;
            ");
        }

        private static string ReadEmbeddedResource(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(name);
            if (stream == null)
            {
                throw new Exception("Resource not found");
            }

            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
