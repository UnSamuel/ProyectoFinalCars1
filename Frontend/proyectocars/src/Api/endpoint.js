import { PROJECTS_CLIENT as client } from "./client";

const getEjemplo = (data) =>
  client({
    url: "TablaEjemplo/CrearTablaEjemplo", 
    method: "POST",
    data,
    headers: {"Content-Type": "application/json"} 
  });


const getTipoMoneda = (data) =>
  client({
    url: "TipoMoneda/MostrarTipoMoneda", 
    method: "GET",
    data,
    headers: {"Content-Type": "application/json"} 
  });

export {
    getEjemplo,
    getTipoMoneda,
    getEjemplos,
}