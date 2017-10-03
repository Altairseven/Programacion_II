select a.*, b.NOMBRE as DOCNOMBRE, c.NOMBRE as LOCNOMBRE, d.NOMBRE AS TIPO_PERSONA from Personas a
inner join Tipo_Documento b on a.ID_TIPO_DOCUMENTO = b.ID
inner join Localidades c on a.ID_LOCALIDAD = c.ID
inner join Tipos_Persona d on a.ID_TIPO_PERSONA = d.ID


select a.*, b.NOMBRE as DOCNOMBRE, c.NOMBRE as LOCNOMBRE from Personas a
inner join Tipo_Documento b on a.ID_TIPO_DOCUMENTO = b.ID
inner join Localidades c on a.ID_TIPO_DOCUMENTO = c.ID

select a.*, b.NOMBRE as DOCNOMBRE , d.NOMBRE AS TIPO_PERSONA from Personas a
inner join Tipo_Documento b on a.ID_TIPO_DOCUMENTO = b.ID
inner join Tipos_Persona d on a.ID_TIPO_PERSONA = d.ID

select a.*, c.* from Personas a
inner join Localidades c on a.ID_TIPO_DOCUMENTO = c.ID

update Personas set ID_LOCALIDAD = 1112;

select * from personas
select * from Localidades