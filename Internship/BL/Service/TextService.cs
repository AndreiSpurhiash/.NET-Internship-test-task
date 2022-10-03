using AutoMapper;
using Internship.DAL.Interfaces;
using Internship.Service.Entity;
using Internship.Service.Interfaces;
using Internship.DAL.Repositories;
using Internship.Domain.Entity;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Text;
using Internship.Contracts.Entity;

namespace Internship.Service.Implementations
{
    public class TextService : ITextService
    {
        private readonly IMapper _mapper;
        private readonly ITextRepository _textRepository;

        public TextService(IMapper mapper, ITextRepository textRepository)
        {
            _mapper = mapper;
            _textRepository = textRepository;
        }
        public async Task CreateText(TextModel textModel)
        {
            var text = _mapper.Map<Text>(textModel);
            await _textRepository.Create(text).ConfigureAwait(false);
            await _textRepository.Save().ConfigureAwait(false);
        }

        public async Task CreateCVSAsync()
        {
            var texts = await _textRepository.GetListAsync().ConfigureAwait(false);

            string path = Environment.CurrentDirectory + @"\text.csv";

            using (var textsCSV = new StreamWriter(path, false, Encoding.GetEncoding("utf-8")))
            {
                using (var csv = new CsvWriter(textsCSV, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = "\t" }))
                {

                    var textsModels = _mapper.Map<IEnumerable<TextModel>>(texts);
                    csv.WriteRecords(textsModels);
                }
            }
        }
    }
}
