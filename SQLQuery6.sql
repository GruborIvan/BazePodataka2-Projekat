

SELECT * FROM (SELECT * FROM [CompanyDbModel].[dbo].[Lokacije] l WHERE l.KompanijaKID != 0) l
LEFT JOIN (SELECT KID FROM [CompanyDbModel].[dbo].[Kompanije] k WHERE k.Direktor_OID != 0) k 
ON l.KompanijaKID = k.KID

SELECT Grad FROM [CompanyDbModel].[dbo].[Osobas] o 
LEFT JOIN [CompanyDbModel].[dbo].[Osobas_Zaposleni] z ON o.OID = z.OID
LEFT JOIN [CompanyDbModel].[dbo].[Kompanije] k ON k.Direktor_OID = z.OID
LEFT JOIN [CompanyDbModel].[dbo].[Lokacije] l ON l.LokID = k.Lokacija_LokID
WHERE OsobaType = 'DIREKTOR' AND RadniStaz = (SELECT max(RadniStaz) FROM [CompanyDbModel].[dbo].[Osobas_Zaposleni] z LEFT JOIN [CompanyDbModel].[dbo].[Osobas] os ON z.OID = os.OID WHERE OsobaType = 'DIREKTOR');

SELECT * FROM [CompanyDbModel].[dbo].[Lokacije] l LEFT JOIN [CompanyDbModel].[dbo].[Kompanije] k ON l.KompanijaKID = k.KID

exec [CompanyDbModel].[dbo].[F_GRAD_DIREKTORA_SA_NAJVECIM_RADNIM_STAZOM]