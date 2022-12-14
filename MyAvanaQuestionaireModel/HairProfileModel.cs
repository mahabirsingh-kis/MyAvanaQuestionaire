using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Text;
using Newtonsoft.Json.Linq;

namespace MyAvanaQuestionaireModel
{

    public class HairProfile
    {
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string HairId { get; set; }
        public string HealthSummary { get; set; }
        public string TopLeftStrandDiameter { get; set; }
        public string TopLeftHealthText { get; set; }
        public string TopRightStrandDiameter { get; set; }
        public string TopRightHealthText { get; set; }
        public string BottomLeftStrandDiameter { get; set; }
        public string BottomLeftHealthText { get; set; }
        public string BottoRightStrandDiameter { get; set; }
        public string BottomRightHealthText { get; set; }
        public string CrownStrandDiameter { get; set; }
        public string CrownHealthText { get; set; }

        public List<Observation> Observation { get; set; }
        public List<Pororsity> Pororsity { get; set; }
        public List<Elasticity> Elasticity { get; set; }

        public string TempObservation { get; set; }
        public string TempPororsity { get; set; }
        public string TempElasticity { get; set; }

        public IFormFile TopLeftFile { get; set; }
        public IFormFile TopRightFile { get; set; }
        public IFormFile BottomLeftFile { get; set; }
        public IFormFile BottomRightFile { get; set; }
        public IFormFile CrownFile { get; set; }

        public string TopLeftPhoto { get; set; }
        public string TopRightPhoto { get; set; }
        public string BottomLeftPhoto { get; set; }
        public string BottomRightPhoto { get; set; }
        public string CrownPhoto { get; set; }

        public List<RecommendedProducts> RecommendedProducts { get; set; }
        public List<RecommendedIngredients> RecommendedIngredients { get; set; }
        public List<RecommendedRegimens> RecommendedRegimens { get; set; }
        public List<RecommendedVideos> RecommendedVideos { get; set; }

        public string TempRecommendedProducts { get; set; }
        public string TempRecommendedIngredients { get; set; }
        public string TempRecommendedRegimens { get; set; }
        public string TempRecommendedVideos { get; set; }
    }

    public class HairProfileAdminModel
    {
        public string UserId { get; set; }
        public string HairId { get; set; }
        public string HealthSummary { get; set; }
        public TopLeft TopLeft { get; set; }
        public TopRight TopRight { get; set; }
        public BottomLeft BottomLeft { get; set; }
        public BottomRight BottomRight { get; set; }
        public CrownStrand CrownStrand { get; set; }
        public List<RecommendedVideos> RecommendedVideos { get; set; }
        public List<RecommendedProductsModel> RecommendedProducts { get; set; }
        public List<RecommendedIngredients> RecommendedIngredients { get; set; }
        public List<RecommendedRegimens> RecommendedRegimens { get; set; }
    }


    public class TopLeft
    {
        public string TopLeftPhoto { get; set; }
        public string TopLeftStrandDiameter { get; set; }
        public string TopLeftHealthText { get; set; }
        public List<Observation> Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class TopRight
    {
        public string TopRightPhoto { get; set; }
        public string TopRightStrandDiameter { get; set; }
        public string TopRightHealthText { get; set; }
        public List<Observation> Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class BottomLeft
    {
        public string BottomLeftPhoto { get; set; }
        public string BottomLeftStrandDiameter { get; set; }
        public string BottomLeftHealthText { get; set; }
        public List<Observation> Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class BottomRight
    {
        public string BottomRightPhoto { get; set; }
        public string BottomRightStrandDiameter { get; set; }
        public string BottomRightHealthText { get; set; }
        public List<Observation> Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class CrownStrand
    {
        public string CrownPhoto { get; set; }
        public string CrownStrandDiameter { get; set; }
        public string CrownHealthText { get; set; }
        public List<Observation> Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class TopLeftAdmin
    {
        public List<string> TopLeftPhoto { get; set; }
        public string TopLeftStrandDiameter { get; set; }
        public string TopLeftHealthText { get; set; }
        public List<HealthModel> Health { get; set; }
        public List<Observation> Observation { get; set; }
        public List<ObsElasticity> obsElasticities { get; set; }
        public List<ObsChemicalProducts> obsChemicalProducts { get; set; }
        public List<ObsPhysicalProducts> obsPhysicalProducts { get; set; }
        public List<ObsDamage> obsDamages { get; set; }
        public List<ObsBreakage> obsBreakages { get; set; }
        public List<ObsSplitting> obsSplittings { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class TopRightAdmin
    {
        public List<string> TopRightPhoto { get; set; }
        public string TopRightStrandDiameter { get; set; }
        public string TopRightHealthText { get; set; }
        public List<HealthModel> Health { get; set; }
        public List<Observation> Observation { get; set; }
        public List<ObsElasticity> obsElasticities { get; set; }
        public List<ObsChemicalProducts> obsChemicalProducts { get; set; }
        public List<ObsPhysicalProducts> obsPhysicalProducts { get; set; }
        public List<ObsDamage> obsDamages { get; set; }
        public List<ObsBreakage> obsBreakages { get; set; }
        public List<ObsSplitting> obsSplittings { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class BottomLeftAdmin
    {
        public List<string> BottomLeftPhoto { get; set; }
        public string BottomLeftStrandDiameter { get; set; }
        public string BottomLeftHealthText { get; set; }
        public List<HealthModel> Health { get; set; }
        public List<Observation> Observation { get; set; }
        public List<ObsElasticity> obsElasticities { get; set; }
        public List<ObsChemicalProducts> obsChemicalProducts { get; set; }
        public List<ObsPhysicalProducts> obsPhysicalProducts { get; set; }
        public List<ObsDamage> obsDamages { get; set; }
        public List<ObsBreakage> obsBreakages { get; set; }
        public List<ObsSplitting> obsSplittings { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class BottomRightAdmin
    {
        public List<string> BottomRightPhoto { get; set; }
        public string BottomRightStrandDiameter { get; set; }
        public string BottomRightHealthText { get; set; }
        public List<HealthModel> Health { get; set; }
        public List<Observation> Observation { get; set; }
        public List<ObsElasticity> obsElasticities { get; set; }
        public List<ObsChemicalProducts> obsChemicalProducts { get; set; }
        public List<ObsPhysicalProducts> obsPhysicalProducts { get; set; }
        public List<ObsDamage> obsDamages { get; set; }
        public List<ObsBreakage> obsBreakages { get; set; }
        public List<ObsSplitting> obsSplittings { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class CrownStrandAdmin
    {
        public List<string> CrownPhoto { get; set; }
        public string CrownStrandDiameter { get; set; }
        public string CrownHealthText { get; set; }
        public List<HealthModel> Health { get; set; }
        public List<Observation> Observation { get; set; }
        public List<ObsElasticity> obsElasticities { get; set; }
        public List<ObsChemicalProducts> obsChemicalProducts { get; set; }
        public List<ObsPhysicalProducts> obsPhysicalProducts { get; set; }
        public List<ObsDamage> obsDamages { get; set; }
        public List<ObsBreakage> obsBreakages { get; set; }
        public List<ObsSplitting> obsSplittings { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class LeftStrand
    {
        public string LeftPhoto { get; set; }
        public string LeftStrandDiameter { get; set; }
        public string LeftHealthText { get; set; }
        public Observation Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class BottomStrand
    {
        public string BottomPhoto { get; set; }
        public string BottomStrandDiameter { get; set; }
        public string BottomHealthText { get; set; }
        public Observation Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class RightStrand
    {
        public string RightPhoto { get; set; }
        public string RightStrandDiameter { get; set; }
        public string RightHealthText { get; set; }
        public Observation Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }

    public class TopStrand
    {
        public string TopPhoto { get; set; }
        public string TopStrandDiameter { get; set; }
        public string TopHealthText { get; set; }
        public Observation Observation { get; set; }
        public Pororsity Pororsity { get; set; }
        public Elasticity Elasticity { get; set; }
    }


    public class Elasticity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class Pororsity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class Observation
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class ObsElasticity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class ObsChemicalProducts
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class ObsPhysicalProducts
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class ObsDamage
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class ObsBreakage
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class ObsSplitting
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }

    public class RecommendedProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }

    }

    public class RecommendedProductsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public int ProductId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }
    }

    public class RecommendedIngredients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IngredientId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }

    }

    public class RecommendedRegimens
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegimenId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }

    }

    public class RecommendedVideos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MediaLinkEntityId { get; set; }
        public string ThumbNail { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }

        public int HairProfileId { get; set; }

    }

    public class HairProfileCustomerModel
    {
        public string UserId { get; set; }
        public string ConsultantNotes { get; set; }
        public string HairId { get; set; }
        public string UserName { get; set; }
        public string HealthSummary { get; set; }
        public string UserUploadedImage { get; set; }
        public TopLeftAdmin TopLeft { get; set; }
        public TopRightAdmin TopRight { get; set; }
        public BottomLeftAdmin BottomLeft { get; set; }
        public BottomRightAdmin BottomRight { get; set; }
        public CrownStrandAdmin CrownStrand { get; set; }
        public List<RecommendedVideosCustomer> RecommendedVideos { get; set; }
        public List<RecommendedProductsCustomer> RecommendedProducts { get; set; }
        public List<RecommendedProductsStylingModel> RecommendedProductsStyling { get; set; }
        public List<RecommendedIngredientsCustomer> RecommendedIngredients { get; set; }
        public List<RecommendedToolsCustomer> RecommendedTools { get; set; }
        public List<RecommendedRegimensCustomer> RecommendedRegimens { get; set; }
        public List<RecommendedStylistCustomer> recommendedStylistCustomers { get; set; }
        public QuestionaireSelectedAnswer SelectedAnswers { get; set; }
        public JObject AIResultDecoded { get; set; }
        public string AIResult { get; set; }
    }

    public class QuestionaireSelectedAnswer
    {
        public string UserEmail { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string TypeId { get; set; }
        public string TypeDescription { get; set; }
        public string TextureId { get; set; }
        public string TextureDescription { get; set; }
        public string HealthId { get; set; }
        public string HealthDescription { get; set; }
        public string PorosityId { get; set; }
        public string PorosityDescription { get; set; }
        public string ElasticityId { get; set; }
        public string ElasticityDescription { get; set; }
        public string DensityId { get; set; }
        public string DensityDescription { get; set; }
        public List<string> Goals { get; set; }
        public List<string> Challenges { get; set; }
    }

    public class RecommendedStylistCustomer
    {
        public int Id { get; set; }
        public int StylistId { get; set; }
        public int HairProfileId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public List<StylistCustomerModel> Stylist { get; set; }
    }

    public class StylistCustomerModel
    {
        public string StylistName { get; set; }
        public string Salon { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Instagram { get; set; }
    }

    public class RecommendedProductsStylingModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public int ProductId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }
        public string ProductParentName { get; set; }
        public List<ProductsTypesStylingModels> ProductsTypes { get; set; }
    }

    public class ProductsTypesStylingModels
    {
        public string ProductTypeName { get; set; }
        public int? ProductId { get; set; }
        public List<ProductsStylingModels> Products { get; set; }
    }
    public class ProductsStylingModels
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ProductLink { get; set; }
        public string BrandName { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductType { get; set; }
        public string ProductDetails { get; set; }
        public string ProductName { get; set; }
    }

    public class RecommendedVideosCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MediaLinkEntityId { get; set; }
        public string ThumbNail { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }
        public List<string> Videos { get; set; }
    }
	public class RecommendedProductsCustomer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string BrandName { get; set; }
		public int ProductId { get; set; }
		public DateTime? CreatedOn { get; set; }
		public bool? IsActive { get; set; }
		public int HairProfileId { get; set; }
		public string ProductParentName { get; set; }
		public List<ProductsTypesModels> ProductsTypes { get; set; }
	}
	public class ProductsTypesModels
	{
		public string ProductTypeName { get; set; }
		public int ProductId { get; set; }
		public List<ProductsModels> Products { get; set; }

	}
	public class RecommendedIngredientsCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IngredientId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }
        public List<IngredientsModels> Ingredients { get; set; }
    }
    public class RecommendedRegimensCustomer
    {
        public int RegimenId { get; set; }
        public string RegimenName { get; set; }
        public string RegimenTitle { get; set; }
        public string Description { get; set; }
        public List<RegimenStepsModel> RegimenSteps { get; set; }
    }
    public class RegimenStepsModel
    {
        public string RegimenStepPhoto { get; set; }
        public string RegimenStepInstruction { get; set; }
    }
    public class ProductsModels
    {
		public string ImageName { get; set; }
		public string ProductLink { get; set; }
		public string BrandName { get; set; }
		public string ProductTypeName { get; set; }
		public string ProductType { get; set; }
		public string ProductDetails { get; set; }
		public string ProductName { get; set; }
	}

    public class IngredientsModels
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
    }

    public class QuestionaireModel
    {
        public string Userid { get; set; }
        public bool? IsExist { get; set; }
        public int? QA { get; set; }
    }

    public class HealthModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsTopLeft { get; set; }
        public bool IsTopRight { get; set; }
        public bool IsBottomLeft { get; set; }
        public bool IsBottomRight { get; set; }
        public bool IsCrown { get; set; }
    }


    public class QuestionAnswerModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public int? QA { get; set; }
        public bool? IsDraft { get; set; }
        public DateTime? CreatedOn { get; set; }
        public ICollection<QuestionModels> questionModel { get; set; }
    }

    public class QuestionModels
    {
        public int? QuestionId { get; set; }
        public string Question { get; set; }
        public int SerialNo { get; set; }
        public string QAType { get; set; }
        public int? QA { get; set; }
        public ICollection<AnswerModel> AnswerList { get; set; }
    }

    public class AnswerModel
    {
        public int? AnswerId { get; set; }
        public string Answer { get; set; }
        public string Description { get; set; }
        public int QA { get; set; }
        public DateTime? QAdate { get; set; }
    }
    public class ToolsModels
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string ToolDetail { get; set; }


    }
    public class RecommendedToolsCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ToolId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? IsActive { get; set; }
        public int HairProfileId { get; set; }

        public List<ToolsModels> ToolList { get; set; }

    }
}
