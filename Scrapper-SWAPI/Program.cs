using Scrapper_SWAPI.Services;

var addDataToDb = new AddDataToDB();

addDataToDb.AddVeiculos();
addDataToDb.AddNaves();
addDataToDb.AddPlanetas();
addDataToDb.AddPersonagens();
addDataToDb.AddFilmes();