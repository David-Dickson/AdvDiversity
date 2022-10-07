using Sabio.Models;
using Sabio.Models.Domain.NewsletterTemplates;
using Sabio.Models.Requests.NewsletterTemplates;
namespace Sabio.Services.Interfaces
{
    public interface INewsletterTemplatesService
    {
        int TemplatesInsert(NewsletterTemplatesInsertRequest model, int userId);
        void TemplatesUpdate(NewsletterTemplatesUpdateRequest model, int userId);
        Paged<NewsletterTemplates> Pagination(int pageIndex, int pageSize);
        Paged<NewsletterTemplates> SearchPagination(int pageIndex, int pageSize, string query);
        void TemplatesDeleteById(int id);



    }
}
