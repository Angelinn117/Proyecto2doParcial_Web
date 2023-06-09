﻿using Proyecto._2doParcial.Core.Entities;

namespace Proyecto._2doParcial.Core.Dto;

public class ApparatusDto :  DtoBase
{
    
    public int fKIdCliente { get; set; }
    public DateTime fechaRecepcion { get; set; }
    public string tipoAparato { get; set; }
    public string marca { get; set; }
    public string descripcionProblematica { get; set; }
    public string descripcionAdicional { get; set; }
    public string ubicacionEstante { get; set; }
    
    public ApparatusDto()
    {

    }
    
    public ApparatusDto(Apparatus apparatus)
    {

        fKIdCliente = apparatus.fKIdCliente;
        fechaRecepcion = apparatus.fechaRecepcion;
        tipoAparato = apparatus.tipoAparato;
        marca = apparatus.marca;
        descripcionProblematica = apparatus.descripcionProblematica;
        descripcionAdicional = apparatus.descripcionAdicional;
        ubicacionEstante = apparatus.ubicacionEstante;
        Id = apparatus.Id;

    }
    
}

