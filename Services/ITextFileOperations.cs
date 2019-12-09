using System.Collections.Generic;

namespace Microgreens.Services
{
    public interface ITextFileOperations
    {
        IEnumerable<string> LoadConditionsForAcceptanceText();


    }
}
