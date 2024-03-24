using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldApp.Model
{
    internal class Country
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public string NumericCode {  get; set; }
        public double Population { get; set; }
        public double Area { get; set; }
        public Country()
        {
            ShortName = string.Empty;
            FullName= string.Empty;
            Alpha2Code = string.Empty;
            Alpha3Code = string.Empty;
            NumericCode = string.Empty;
        }
        public override string ToString()
        {
            return $"{Id} - {ShortName} - {FullName} - {Alpha2Code} - {Alpha3Code} - {NumericCode} " +
                $"- {Population}th.p. - {Area}sq.k.";
        }
    }
}
