ALTER FUNCTION F_GRAD_DIREKTORA_SA_NAJMANJIM_RADNIM_STAZOM
()
RETURNS DECIMAL AS
	BEGIN
		DECLARE @Grad AS DECIMAL
		SELECT @Grad=Grad FROM [CompanyDbModel].[dbo].[Osobas] o 
		LEFT JOIN [CompanyDbModel].[dbo].[Osobas_Zaposleni] z ON o.OID = z.OID
		LEFT JOIN [CompanyDbModel].[dbo].[Kompanije] k ON k.Direktor_OID = z.OID
		LEFT JOIN [CompanyDbModel].[dbo].[Lokacije] l ON l.LokID = k.Lokacija_LokID
		WHERE OsobaType = 'DIREKTOR' AND CAST(RadniStaz AS INT) = 
		(SELECT min(RadniStaz) FROM [CompanyDbModel].[dbo].[Osobas_Zaposleni] z 
		LEFT JOIN [CompanyDbModel].[dbo].[Osobas] os ON z.OID = os.OID WHERE OsobaType = 'DIREKTOR');
		RETURN @Grad
	END