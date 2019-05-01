using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyAustralia.Models;
using EnergyAustralia.Domain.Contracts;
using System.Net.Http;
using Newtonsoft.Json;

namespace EnergyAustralia.Domain.Services
{
    public class CarShowService : ICarShowService
    {
        private readonly HttpClient _httpClient;

        public CarShowService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://eacodingtest.digital.energyaustralia.com.au");
        }

        public async Task<IEnumerable<CarShow>> GetCarShows()
        {
            using(var response = await _httpClient.GetAsync("api/v1/cars", HttpCompletionOption.ResponseHeadersRead))
            {
                if (response.IsSuccessStatusCode) {
                    var data = await response.Content.ReadAsStringAsync();


                    var del = data;
                    return JsonConvert.DeserializeObject<List<CarShow>>(data);
                }
                throw new Exception(response.ReasonPhrase);
            }
            
        }
    }
}

