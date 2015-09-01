using System.Collections.Generic;
using Nest.Indexify.Contributors.Analysis.Analyzers;

namespace Nest.Indexify.Contributors.Autocomplete
{
	public class AutoCompleteAnalyzerContributor : IndexAnalysisAnalyzerContributor
	{
		private readonly string _name;
		private readonly string _tokenFilter;

		public AutoCompleteAnalyzerContributor(string name, string tokenFilter, int order = 0) : base(order)
		{
			_name = name;
			_tokenFilter = tokenFilter;
		}

	    public override bool CanContribute(ICreateIndexRequest indexRequest)
	    {
	        return indexRequest.IndexSettings.Analysis.TokenFilters.ContainsKey(_tokenFilter);
	    }

	    protected override IEnumerable<KeyValuePair<string, AnalyzerBase>> Build()
		{
			yield return new KeyValuePair<string, AnalyzerBase>(_name, new CustomAnalyzer
			{
				Tokenizer = new WhitespaceTokenizer().Type,
				Filter = new[] {new LowercaseTokenFilter().Type, new AsciiFoldingTokenFilter().Type, _tokenFilter}
			});
		}
	}
}