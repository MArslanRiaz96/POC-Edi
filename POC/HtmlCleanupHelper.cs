using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC
{
    public class HtmlCleanupHelper
    {
        #region Private Member Variables
        private HtmlDocument document;
        #endregion

        #region Public Members
        public HtmlCleanupHelper(string html)
        {
            document = new HtmlDocument();
            document.LoadHtml(html);
        }
        #endregion

        #region Public Method
        public static string ExecuteCleanup(string html)
        {
            try
            {

                HtmlCleanupHelper helper = new HtmlCleanupHelper(html);

                helper.RemoveRowsWithEmptySpans();
                helper.RemoveEmptyTablesAndAdjacentBTags();
                helper.RemoveEmptyColumnsRowsTables();

                return helper.GetCleanedHtml();
            }
            catch (Exception)
            {
                return html;
            }
        }
        public string GetCleanedHtml()
        {
            return document.DocumentNode.OuterHtml;
        }
        #endregion

        #region Private Method
        private void RemoveRowsWithEmptySpans()
        {
            var tables = document.DocumentNode.SelectNodes("//table");

            if (tables != null)
            {
                foreach (var table in tables)
                {
                    var rows = table.SelectNodes(".//tr");

                    if (rows != null)
                    {
                        for (int j = rows.Count - 1; j >= 0; j--)
                        {
                            var row = rows[j];
                            var spans = row.SelectNodes(".//span");
                            var shouldRemoveRow = false;

                            if (spans != null)
                            {
                                foreach (var span in spans)
                                {
                                    var spanValue = span.InnerText.Trim();

                                    if (string.IsNullOrEmpty(spanValue) || spanValue == "(: )" || spanValue == ":")
                                    {
                                        shouldRemoveRow = true;
                                        break;
                                    }
                                }
                            }

                            if (shouldRemoveRow)
                            {
                                row.Remove();
                            }
                        }
                    }
                }
            }
        }

        private void RemoveEmptyTablesAndAdjacentBTags()
        {
            var tables = document.DocumentNode.SelectNodes("//table");

            if (tables != null)
            {
                foreach (var table in tables)
                {
                    RemoveEmptyTablesAndAdjacentBTagsRecursive(table);
                }
            }
        }

        private void RemoveEmptyTablesAndAdjacentBTagsRecursive(HtmlNode table)
        {
            var rows = table.SelectNodes(".//tr");

            if ((table != null && table.InnerHtml.Trim() == string.Empty) || (rows != null && rows.Count == 0))
            {
                var previousElement = table.PreviousSibling;
                while (previousElement != null && previousElement.NodeType != HtmlNodeType.Element)
                {
                    previousElement = previousElement.PreviousSibling;
                }

                if (previousElement != null && previousElement.Name == "b")
                {
                    previousElement.Remove();
                }

                table.Remove();
            }
            else
            {
                var nestedTables = table.SelectNodes(".//table");

                if (nestedTables != null)
                {
                    foreach (var nestedTable in nestedTables)
                    {
                        RemoveEmptyTablesAndAdjacentBTagsRecursive(nestedTable);
                    }
                }
            }
        }

        private void RemoveEmptyColumnsRowsTables()
        {
            var tables = document.DocumentNode.SelectNodes("//table");

            if (tables != null)
            {
                foreach (var table in tables)
                {
                    RemoveEmptyCoumnsAndRows(table);
                    RemoveEmptyTable(table);
                }
            }
        }

        private void RemoveEmptyCoumnsAndRows(HtmlNode table)
        {
            var rows = table.SelectNodes(".//tr");

            if (rows != null)
            {
                foreach (var row in rows)
                {
                    var columns = row.SelectNodes(".//td|.//th");

                    if (columns != null)
                    {
                        foreach (var column in columns)
                        {
                            var text = column.InnerText.Trim();
                            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
                            {
                                column.Remove();
                            }
                        }
                    }
                }
            }
        }

        private void RemoveEmptyTable(HtmlNode table)
        {
            var rows = table.SelectNodes(".//tr");
            if (rows != null && rows.Count > 0)
            {
                var shouldRemoveTable = true;
                foreach (var row in rows)
                {
                    var text = row.InnerHtml.Trim();
                    if (!string.IsNullOrEmpty(text) || !string.IsNullOrEmpty(text))
                    {
                        shouldRemoveTable = false;
                        break;
                    }
                }

                if (shouldRemoveTable)
                    table.Remove();
            }

            if (table != null)
            {
                var nestedTables = table.SelectNodes(".//table");

                if (nestedTables != null)
                {
                    foreach (var nestedTable in nestedTables)
                    {
                        RemoveEmptyCoumnsAndRows(nestedTable);
                        RemoveEmptyTable(nestedTable);
                    }
                }
            }
        }
        #endregion

    }
}
