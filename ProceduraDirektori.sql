CREATE PROCEDURE C_INS_Direktori
(
	@OID int,
	@Ime VARCHAR(30),
	@Prezime VARCHAR(30),
	@JMBG int,
	@RadniStaz VARCHAR(5),
	@UgovorId int
)
AS
BEGIN TRY
	INSERT INTO [dbo].[Osobas] (Ime,Prezime,OsobaType,JMBG) VALUES (@Ime,@Prezime,'DIREKTOR',@JMBG);
	INSERT INTO [dbo].[Osobas_Zaposleni] (OID,RadniStaz,UgovorUID) VALUES (@OID,@RadniStaz,@UgovorId)
END TRY

BEGIN CATCH
	SELECT 
		ERROR_NUMBER() AS ErrorNumber,
		ERROR_MESSAGE() AS ErrorMessage 
END CATCH