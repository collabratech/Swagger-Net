﻿namespace Swagger.Net.Dummy.SwaggerExtensions
{
    public class AddMessageDefault : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaRegistry schemaRegistry, System.Type type)
        {
            schema.example = schema.@default = new { title = "A message", content = "Some content" };
        }
    }
}
