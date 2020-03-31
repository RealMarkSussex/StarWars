using GemBox.Spreadsheet;
using StarWarsBackend.Models;
using System.IO;

namespace StarWarsBackend
{
    public class Excel
    {
        private readonly Person _person;
        private readonly ExcelFile _workbook;
        public Excel(Person person)
        {
            _person = person;
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            _workbook = new ExcelFile();
        }
        public byte[] Create()
        {
            var options = SaveOptions.XlsxDefault;
            CreatePersonWorksheet();

            return GetBytes(_workbook, options);
        }

        private void CreatePersonWorksheet()
        {
            var worksheet = _workbook.Worksheets.Add(_person.Name);

            var style = worksheet.Rows[0].Style;
            style.Font.Weight = ExcelFont.BoldWeight;
            style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            worksheet.Columns[0].Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;

            worksheet.Columns[0].SetWidth(50, LengthUnit.Pixel);
            worksheet.Columns[1].SetWidth(150, LengthUnit.Pixel);
            worksheet.Columns[2].SetWidth(150, LengthUnit.Pixel);
            worksheet.Columns[3].SetWidth(150, LengthUnit.Pixel);
            worksheet.Columns[4].SetWidth(150, LengthUnit.Pixel);
            worksheet.Columns[5].SetWidth(150, LengthUnit.Pixel);
            worksheet.Columns[6].SetWidth(150, LengthUnit.Pixel);

            worksheet.Cells["A1"].Value = "Name";
            worksheet.Cells["B1"].Value = "Birth Year";
            worksheet.Cells["C1"].Value = "Eye Colour";
            worksheet.Cells["D1"].Value = "Hair Colour";
            worksheet.Cells["E1"].Value = "Height";
            worksheet.Cells["F1"].Value = "Mass";
            worksheet.Cells["G1"].Value = "Skin Colour";


            worksheet.Cells["A2"].Value = _person.Name;
            worksheet.Cells["B2"].Value = _person.Birth_Year;
            worksheet.Cells["C2"].Value = _person.Eye_Color;
            worksheet.Cells["D2"].Value = _person.Hair_Color;
            worksheet.Cells["E2"].Value = _person.Height;
            worksheet.Cells["F2"].Value = _person.Mass;
            worksheet.Cells["G2"].Value = _person.Skin_Color;
        }

        private static byte[] GetBytes(ExcelFile file, SaveOptions options)
        {
            using (var stream = new MemoryStream())
            {
                file.Save(stream, options);
                return stream.ToArray();
            }
        }

    }
}
