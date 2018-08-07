using System.Collections.Generic;
using Framework.Lib.Entities.Objects;
using Framework.Lib.Pages;
using Framework.Lib.Pages.Common;

namespace Framework.Lib.Services
{
    public class YandexMarketService : IService
    {
        public void SearchByQuery(string query)
        {
            new Header()
                .SendKeysToSearchInput(query)
                .ClickSearchSubmitButton();
        }

        public SearchResult GetSearchResultByName(string name) => new SearchResultPage().GetResult(name);

        public List<SearchResult> GetSearchResults() => new SearchResultPage().GetResults();

        public List<string> GetSummaryList() => new ProductPage().GetSummaryList();

        public void Login(string login, string password)
        {
            new Header().ClickLoginButton();
            new LoginPage()
                .SendKeysLoginInput(login)
                .SendKeysPasswordInput(password)
                .ClickConfirmButton();
        }
    }
}
