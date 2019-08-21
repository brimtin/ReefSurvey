Location 
{
	BatchCode (PK)
	Region  
	SubRegion
	Longitude
	Latitute
}

Fish
{
	ScientificName  (PK)
	SubRegion       (FK)
	CommonName
	Family
	Trophic
	FishLength
	StructureType
}

Survey
{
	SurveyIndex    (PK)
	ScientificName (FK)
	BatchCode	   (FK)
	StudyArea
	SurveyDate
	SurveyYear
	Management
	FishCount
	
	

}