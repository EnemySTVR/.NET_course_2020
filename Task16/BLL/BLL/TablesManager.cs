using System.Collections;
using System.Data;

namespace BLL
{
    static class TablesManager
    {
        public static DataView CreateDataView<T>(T list)
            where T : IList
        {
            var table = new DataTable();

            if (list.Count == 0)
            {
                return null;
            }

            var properties = list[0].GetType().GetProperties();
            foreach (var property in properties)
            {
                table.Columns.Add(property.Name, property.PropertyType);
            }

            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var row = table.NewRow();
                    for (int j = 0; j < properties.Length; j++)
                    {
                        row[properties[j].Name] = properties[j].GetValue(list[i]);
                    }
                    table.Rows.Add(row);
                }
            }

            return new DataView(table);
        }
    }
}
