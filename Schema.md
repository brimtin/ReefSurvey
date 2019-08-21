Location 
{
	LocationID  	(PK) 
	RegionID 		(FK)
	Longitude
	Latitute
}
Region
{
	RegionID		(PK)
	Region
	SubRegion
}
Survey
{
	SurveyID 		(PK) 
	ObservationID   (FK)
	SurveyIndex   
	BatchCode	   
	StudyArea
	SurveyDate
	SurveyYear
	Management
	FishCount
}
FishObserved
{
	ObservationID 	(PK)
	MetricID		(FK)
	LocationID		(FK)
	Family
	Trophic
}
FishInfo
{
	MetricID		(PK)
	FishID			(FK)
	FishLength
	StructureType
}
FishName
{
	FishID   (Pk ) Int
	ScientificName
	CommonName
}