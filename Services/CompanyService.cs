using System.Net.Http.Json;
using CompanyBlazorApp.Models;
using System.Diagnostics;
using CompanyBlazorApp.Helpers;

namespace CompanyBlazorApp.Services;

/// <summary>
/// Palveluluokka yritystietojen hakemiseen PRH:n avoimesta rajapinnasta.
/// Service class for retrieving company information from the PRH open interface.
/// </summary>
public class CompanyService
{
    private readonly HttpClient _http;
    private readonly ConsoleHelper _console;

    /// <summary>
    /// Luo uuden instanssin <see cref="CompanyService"/>-luokasta.
    /// Creates a new instance of the CompanyService class.
    /// </summary>
    /// <param name="http">HttpClient, jota käytetään API-kutsuihin. HttpClient, which is used for API calls.</param>
    /// <param name="console">ConsoleHelper lokitukseen selaimen konsoliin. Helper for logging to the browser console.</param>
    public CompanyService(HttpClient http, ConsoleHelper console)
    {
        _http = http;
        _console = console;
    }    

    /// <summary>
    /// Hakee yritystietoja annetun Y-tunnuksen perusteella.
    /// Searches for company information based on the provided Business ID.
    /// </summary>
    /// <param name="businessId">Y-tunnus, jota käytetään hakuehtona. Business ID used as a search criterion.</param>
    /// <returns>Listan yrityksistä tai tyhjän listan, jos tietoja ei löytynyt tai tapahtui virhe. List of companies or an empty list if no data was found or an error occurred.</returns>
    public async Task<List<Company>> GetCompaniesAsync(string businessId)
    {
        try
        {
            var url = $"https://avoindata.prh.fi/opendata-ytj-api/v3/companies?businessId={businessId}";
            
            // Kirjoittaa haettavan URL-osoitteen selaimen konsoliin (F12 -> Console).
            // Enters the URL to search for in the browser console  (F12 -> Console).
            await _console.Log($"Haetaan: {url}");

            // Suoritetaan HTTP GET -kutsu ja deserialisoidaan JSON-vastaus Root-olioon.
            // Performs an HTTP GET call and deserialize the JSON response to the Root object.
            var response = await _http.GetFromJsonAsync<Root>(url);
            
            if(response != null)
            {
                // Lokitetaan tulosten määrä.
                // Logging the number of results.
                await _console.Log($"Saatiin {response.totalResults} tulosta.");
            }
            else
            {
                await _console.Warn("response on null!");
            }

            // Palautetaan lista yrityksiä tai tyhjä lista jos response oli null.
            // Returns a list of attempts or an empty list if the response was null.
            return response?.companies ?? new List<Company>();
        }    
        catch (Exception ex)
        {
            // Lokitetaan virhetilanne konsoliin.
            // Logging the error to the console.
            await _console.Error("Virhe yritystä haettaessa: " + ex.Message);            

            return new List<Company>();
        }
    }
}