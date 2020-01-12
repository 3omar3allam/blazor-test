using BlazorClient.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DemoApp.Client.Pages
{
    public partial class FormComponent : ComponentBase
    {
        public FormModel Model { get; set; }
        public bool ShowResponse { get; set; }
        public string AlertClass { get; set; }

        [Inject] private HttpClient Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Model = new FormModel();
            try
            {
                Model = await Http.GetJsonAsync<FormModel>("api/Form");
            }
            catch
            { }
            ShowResponse = false;
        }

        protected async Task HandleValidSubmit()
        {
            try
            {
                var response = await HttpClientJsonExtensions.PostJsonAsync<ResponseObject<FormModel>>(Http, "api/Form", Model);
                if (response?.Data != null)
                {
                    Model = response.Data;
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected async Task HandleInvalidSubmit()
        {
            try
            {
                var response = await HttpClientJsonExtensions.PostJsonAsync<ResponseObject<FormModel>>(Http, "api/Form", Model);
                if (response?.Data != null)
                {
                    Model = response.Data;
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
