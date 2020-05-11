﻿
using System.Collections.Generic;
using UrbanDictionary.BusinessLayer.DTO;

namespace UrbanDictionary.BusinessLayer.Services.Contracts
{
    /// <summary>
    /// Contains methods for performing actions with words for current <c>User</c>.
    /// </summary>
    /// <remarks>
    /// This class can get saved and created words, delete  words from saved ones and edit created ones.
    /// </remarks>
    public interface IUserWordsService
    {
        public IEnumerable<WordDTO> GetSavedWords();
        public bool TryAddToSavedWords(long id);
        public bool TryDeleteSavedWord(long id);

        public IEnumerable<WordDTO> GetCreatedWords();
        bool TryCreateWord(CreateEditFormWordDTO wordDto);
        bool TryEditCreatedWord(CreateEditFormWordDTO wordDTO);
    }
}
