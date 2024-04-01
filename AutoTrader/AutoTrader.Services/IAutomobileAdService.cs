using System;
using System.Collections.Generic;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
    public interface IAutomobileAdService : ICRUDService<Model.AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequest, AutomobileAdUpdateRequest>
    {

    }
}
