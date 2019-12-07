﻿namespace Optivem.EShop.Basket.Web.UI.Client.Interface.Pages
{
    public interface ICreateCustomerPage
    {
        void InputFirstName(string firstName);

        void InputLastName(string lastName);

        void ClickCreate();

        string ReadErrorMessage();
    }
}