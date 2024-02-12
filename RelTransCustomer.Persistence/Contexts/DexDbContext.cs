using Dex.Entities;
using Microsoft.EntityFrameworkCore;

namespace RelTransCustomer.Persistence.Contexts;

public partial class DexDbContext : DbContext
{
    public DexDbContext(DbContextOptions<DexDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Catalog> Catalog { get; set; }

    public virtual DbSet<DesignBobbins> DesignBobbins { get; set; }

    public virtual DbSet<DesignBom> DesignBom { get; set; }

    public virtual DbSet<DesignBomtree> DesignBomtree { get; set; }

    public virtual DbSet<DesignCableBox> DesignCableBox { get; set; }

    public virtual DbSet<DesignCableBoxExtras> DesignCableBoxExtras { get; set; }

    public virtual DbSet<DesignCalcImpedance> DesignCalcImpedance { get; set; }

    public virtual DbSet<DesignCheck> DesignCheck { get; set; }

    public virtual DbSet<DesignCheckLog> DesignCheckLog { get; set; }

    public virtual DbSet<DesignCoilInsulation> DesignCoilInsulation { get; set; }

    public virtual DbSet<DesignConservators> DesignConservators { get; set; }

    public virtual DbSet<DesignCoreClamps> DesignCoreClamps { get; set; }

    public virtual DbSet<DesignCores> DesignCores { get; set; }

    public virtual DbSet<DesignDrawingSchedule> DesignDrawingSchedule { get; set; }

    public virtual DbSet<DesignDrawingScheduleDetail> DesignDrawingScheduleDetail { get; set; }

    public virtual DbSet<DesignDrawingScheduleLog> DesignDrawingScheduleLog { get; set; }

    public virtual DbSet<DesignFittingProps> DesignFittingProps { get; set; }

    public virtual DbSet<DesignFittings> DesignFittings { get; set; }

    public virtual DbSet<DesignGa> DesignGa { get; set; }

    public virtual DbSet<DesignGaHistory> DesignGaHistory { get; set; }

    public virtual DbSet<DesignJobHistory> DesignJobHistory { get; set; }

    public virtual DbSet<DesignLabels> DesignLabels { get; set; }

    public virtual DbSet<DesignLeadBends> DesignLeadBends { get; set; }

    public virtual DbSet<DesignLeadHoles> DesignLeadHoles { get; set; }

    public virtual DbSet<DesignLeads> DesignLeads { get; set; }

    public virtual DbSet<DesignLog> DesignLog { get; set; }

    public virtual DbSet<DesignMain> DesignMain { get; set; }

    public virtual DbSet<DesignParameters> DesignParameters { get; set; }

    public virtual DbSet<DesignRadiators> DesignRadiators { get; set; }

    public virtual DbSet<DesignRads> DesignRads { get; set; }

    public virtual DbSet<DesignRadsOld> DesignRadsOld { get; set; }

    public virtual DbSet<DesignRangeExclusions> DesignRangeExclusions { get; set; }

    public virtual DbSet<DesignReactanceData> DesignReactanceData { get; set; }

    public virtual DbSet<DesignRibs> DesignRibs { get; set; }

    public virtual DbSet<DesignStepCores> DesignStepCores { get; set; }

    public virtual DbSet<DesignTanks> DesignTanks { get; set; }

    public virtual DbSet<DesignTaps> DesignTaps { get; set; }

    public virtual DbSet<DesignTestGroupDetail> DesignTestGroupDetail { get; set; }

    public virtual DbSet<DesignTestGroups> DesignTestGroups { get; set; }

    public virtual DbSet<DesignTestResults> DesignTestResults { get; set; }

    public virtual DbSet<DesignUnlock> DesignUnlock { get; set; }

    public virtual DbSet<DesignWindings> DesignWindings { get; set; }

    public virtual DbSet<DesignWire> DesignWire { get; set; }

    public virtual DbSet<DesignWireBak> DesignWireBak { get; set; }

    public virtual DbSet<ErrorLog> ErrorLog { get; set; }

    public virtual DbSet<JobPartsUsedLog> JobPartsUsedLog { get; set; }

    public virtual DbSet<ProfilingJob> ProfilingJob { get; set; }

    public virtual DbSet<ProjectInUse> ProjectInUse { get; set; }

    public virtual DbSet<RtenquiryDesign> RtenquiryDesign { get; set; }

    public virtual DbSet<TempBobbins> TempBobbins { get; set; }

    public virtual DbSet<TempBom> TempBom { get; set; }

    public virtual DbSet<TempCablebox> TempCablebox { get; set; }

    public virtual DbSet<TempConservators> TempConservators { get; set; }

    public virtual DbSet<TempCoreclamps> TempCoreclamps { get; set; }

    public virtual DbSet<TempCores> TempCores { get; set; }

    public virtual DbSet<TempJobhistory> TempJobhistory { get; set; }

    public virtual DbSet<TempLog> TempLog { get; set; }

    public virtual DbSet<TempMain> TempMain { get; set; }

    public virtual DbSet<TempRadiators> TempRadiators { get; set; }

    public virtual DbSet<TempRibs> TempRibs { get; set; }

    public virtual DbSet<TempStepcores> TempStepcores { get; set; }

    public virtual DbSet<TempTable> TempTable { get; set; }

    public virtual DbSet<TempTable1> TempTable1 { get; set; }

    public virtual DbSet<TempTanks> TempTanks { get; set; }

    public virtual DbSet<TempTaps> TempTaps { get; set; }

    public virtual DbSet<TempWindings> TempWindings { get; set; }

    public virtual DbSet<TempWire> TempWire { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Catalog>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.AnglePdf).HasColumnName("AnglePDF");
            entity.Property(e => e.Authorised).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.DocTitle).HasMaxLength(50);
            entity.Property(e => e.Future1).HasMaxLength(50);
            entity.Property(e => e.Future2).HasMaxLength(50);
            entity.Property(e => e.Future3).HasMaxLength(50);
            entity.Property(e => e.Iso9001)
                .HasMaxLength(50)
                .HasColumnName("ISO9001");
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Revision).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.What).HasMaxLength(50);
        });

        modelBuilder.Entity<DesignBobbins>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo });

            entity.ToTable("Design_Bobbins");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinProductId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BobbinProductID");
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FlangeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadPosOnBobbin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignBom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_BOM");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073047").IsClustered();

            entity.Property(e => e.Bomid).HasColumnName("BOMID");
            entity.Property(e => e.Cost6)
                .HasColumnType("money")
                .HasColumnName("Cost_6");
            entity.Property(e => e.CostingOnly).HasDefaultValue(false);
            entity.Property(e => e.Cpa8)
                .HasColumnType("money")
                .HasColumnName("CPA_8");
            entity.Property(e => e.Description2)
                .IsUnicode(false)
                .HasColumnName("Description_2");
            entity.Property(e => e.DexPart0)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DexPart_0");
            entity.Property(e => e.DiscountCost).HasColumnType("money");
            entity.Property(e => e.DiscountTotal).HasColumnType("money");
            entity.Property(e => e.EnvisageRef12).HasColumnName("EnvisageRef_12");
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KeepSeparate).HasDefaultValue(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lock)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.ProductId3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductID_3");
            entity.Property(e => e.Qty4).HasColumnName("Qty_4");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardUnits11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Standard_Units_11");
            entity.Property(e => e.TotalAmount9)
                .HasColumnType("money")
                .HasColumnName("TotalAmount_9");
            entity.Property(e => e.Units5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Units_5");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.Waste7).HasColumnName("Waste_7");
        });

        modelBuilder.Entity<DesignBomtree>(entity =>
        {
            entity.ToTable("Design_BOMTree");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Node)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NodeId).HasColumnName("NodeID");
            entity.Property(e => e.Parent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignCableBox>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_CableBox");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073151").IsClustered();

            entity.Property(e => e.BushingOutsideLength).HasColumnName("BushingOutsideLEngth");
            entity.Property(e => e.CboxLidType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CBoxLidType");
            entity.Property(e => e.CboxRimBoltPitch).HasColumnName("CBoxRimBoltPitch");
            entity.Property(e => e.CboxRimBoltQty).HasColumnName("CBoxRimBoltQTY");
            entity.Property(e => e.CboxRimBoltSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBoxRimBoltSpec");
            entity.Property(e => e.CorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GlandPlateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndoorBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutdoorBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardBox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardPocket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stdcbox).HasColumnName("STDCBox");
            entity.Property(e => e.Stdpocket).HasColumnName("STDPocket");
            entity.Property(e => e.TermPlateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Terminations)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignCableBoxExtras>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("Design_CableBox_Extras");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignCalcImpedance>(entity =>
        {
            entity.HasKey(e => new { e.RecId, e.SpecNo, e.RevNo });

            entity.ToTable("Design_CalcImpedance");

            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mlt).HasColumnName("MLT");
            entity.Property(e => e.Od1).HasColumnName("OD1");
            entity.Property(e => e.Od1total).HasColumnName("OD1Total");
            entity.Property(e => e.Od2).HasColumnName("OD2");
            entity.Property(e => e.Od2total).HasColumnName("OD2Total");
            entity.Property(e => e.Wlength).HasColumnName("WLength");
        });

        modelBuilder.Entity<DesignCheck>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("Design_Check");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.DesignerNotes).IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ManagerNotes).IsUnicode(false);
            entity.Property(e => e.RequestedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RequestedOn).HasColumnType("datetime");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<DesignCheckLog>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("Design_Check_Log");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Designer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignCoilInsulation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_CoilInsulation");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073234").IsClustered();

            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignConservators>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_Conservators");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073253").IsClustered();

            entity.Property(e => e.ConsStandard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NettOilLitres).HasDefaultValue(0.0);
            entity.Property(e => e.PaintMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignCoreClamps>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_CoreClamps");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073312").IsClustered();

            entity.Property(e => e.BftoEdge).HasColumnName("BFToEdge");
            entity.Property(e => e.CclampId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampID");
            entity.Property(e => e.CclampLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampLabel");
            entity.Property(e => e.ClampsFeetPaint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSuppGbgauge).HasColumnName("CoilSuppGBGauge");
            entity.Property(e => e.CoilSuppGblength).HasColumnName("CoilSuppGBLength");
            entity.Property(e => e.CoilSuppGbmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoilSuppGBMaterial");
            entity.Property(e => e.CoilSuppGbwidth).HasColumnName("CoilSuppGBWidth");
            entity.Property(e => e.CoilSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSuppShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSupportSinDoub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreClampMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutOutSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveLockBoltMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FramePos)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FrameSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieNutsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MountHolePositions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardCclamp).HasColumnName("StandardCClamp");
            entity.Property(e => e.StiffenerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StiffenerProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TswitchHolY).HasColumnName("TSwitchHolY");
            entity.Property(e => e.TswitchHoleCentre).HasColumnName("TSwitchHoleCentre");
            entity.Property(e => e.TswitchHoleDia).HasColumnName("TSwitchHoleDia");
            entity.Property(e => e.TswitchHoleX).HasColumnName("TSwitchHoleX");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.VerTieNutsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieRodMaterial1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieStyle)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignCores>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo });

            entity.ToTable("Design_Cores");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinProductId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BobbinProductID");
            entity.Property(e => e.BobbinRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CclampRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampRef");
            entity.Property(e => e.ChildBobbins)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChildCclamps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChildCClamps");
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Corename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeCsa).HasColumnName("FeCSA");
            entity.Property(e => e.FlangeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LamsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimbClamps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.VentbRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WattsPerKg).HasColumnName("WattsPerKG");
            entity.Property(e => e.WedgeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignDrawingSchedule>(entity =>
        {
            entity.ToTable("Design_DrawingSchedule");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lock).HasDefaultValue(false);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignDrawingScheduleDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_DrawingScheduleDetail");

            entity.HasIndex(e => e.DrawingScheduleId, "ClusteredIndex-20230729-073355").IsClustered();

            entity.Property(e => e.CompletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.ComponentMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComponentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComponentQty).HasColumnName("ComponentQTY");
            entity.Property(e => e.ComponentStockCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrawingScheduleId).HasColumnName("DrawingScheduleID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignDrawingScheduleLog>(entity =>
        {
            entity.ToTable("Design_DrawingScheduleLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.After)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Before)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Event)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Part)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignFittingProps>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_FittingProps");

            entity.Property(e => e.FittingId).HasColumnName("FittingID");
            entity.Property(e => e.FittingPropId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FittingPropID");
            entity.Property(e => e.PropName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropValue)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignFittings>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo, e.FittingType });

            entity.ToTable("Design_Fittings");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FittingType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FittingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FittingID");
            entity.Property(e => e.FittingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignGa>(entity =>
        {
            entity.HasKey(e => e.Recid).HasName("PK__Design_G__A9A5B3BBD0D0C02B");

            entity.ToTable("Design_GA");

            entity.Property(e => e.Recid).HasColumnName("RECID");
            entity.Property(e => e.AccNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DocName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileLocation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignGaHistory>(entity =>
        {
            entity.HasKey(e => e.Recid);

            entity.ToTable("Design_GA_History");

            entity.Property(e => e.Recid).HasColumnName("RECID");
            entity.Property(e => e.Copied)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GaId).HasColumnName("GA_ID");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Recipient)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Sender)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignJobHistory>(entity =>
        {
            entity.ToTable("Design_JobHistory");

            entity.HasIndex(e => e.Jobno, "NonClusteredIndex-20230729-092824");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.Envcosting)
                .HasColumnType("money")
                .HasColumnName("ENVCOSTING");
            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Publishdate)
                .HasColumnType("datetime")
                .HasColumnName("PUBLISHDATE");
            entity.Property(e => e.Publishedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHEDBY");
            entity.Property(e => e.Revno).HasColumnName("REVNO");
            entity.Property(e => e.Specno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPECNO");
        });

        modelBuilder.Entity<DesignLabels>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_Labels");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073532").IsClustered();

            entity.Property(e => e.LabelMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignLeadBends>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_LeadBends");

            entity.Property(e => e.InOut)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.Sqlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SQLID");
        });

        modelBuilder.Entity<DesignLeadHoles>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_leadHoles");

            entity.Property(e => e.LeadId).HasColumnName("LeadID");
            entity.Property(e => e.Sqlid).HasColumnName("SQLID");
        });

        modelBuilder.Entity<DesignLeads>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_Leads");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sqlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SQLID");
            entity.Property(e => e.TapId).HasColumnName("TapID");
        });

        modelBuilder.Entity<DesignLog>(entity =>
        {
            entity.ToTable("Design_Log");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CheckedInOut)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Checked In/Out");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignMain>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo });

            entity.ToTable("Design_Main");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Altitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssemblySpecPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssemblySpecPDF");
            entity.Property(e => e.AuxWiringType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AxleMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BftoEdge).HasColumnName("BFToEdge");
            entity.Property(e => e.BreatherMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BreatherPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BuchholzFlangesMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BucholtzCodia).HasColumnName("BucholtzCODIA");
            entity.Property(e => e.BucholtzCox).HasColumnName("BucholtzCOX");
            entity.Property(e => e.BucholtzCoy).HasColumnName("BucholtzCOY");
            entity.Property(e => e.BucholtzMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CableRailBgauge).HasColumnName("CableRailBGauge");
            entity.Property(e => e.CableRailBqty).HasColumnName("CableRailBQTY");
            entity.Property(e => e.CableRailBtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CableRailBType");
            entity.Property(e => e.CableRailQty).HasColumnName("CableRailQTY");
            entity.Property(e => e.CableRailType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CclampAssyDrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampAssyDrawingPDF");
            entity.Property(e => e.CclampDrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampDrawingPDF");
            entity.Property(e => e.CclampId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampID");
            entity.Property(e => e.CclampLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampLabel");
            entity.Property(e => e.Cg1gauge).HasColumnName("CG1Gauge");
            entity.Property(e => e.Cg1length).HasColumnName("CG1Length");
            entity.Property(e => e.Cg1material)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG1Material");
            entity.Property(e => e.Cg1position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG1Position");
            entity.Property(e => e.Cg1qty).HasColumnName("CG1QTY");
            entity.Property(e => e.Cg1width).HasColumnName("CG1Width");
            entity.Property(e => e.Cg2gauge).HasColumnName("CG2Gauge");
            entity.Property(e => e.Cg2length).HasColumnName("CG2Length");
            entity.Property(e => e.Cg2material)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG2Material");
            entity.Property(e => e.Cg2position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG2Position");
            entity.Property(e => e.Cg2qty).HasColumnName("CG2QTY");
            entity.Property(e => e.Cg2width).HasColumnName("CG2Width");
            entity.Property(e => e.Cg3gauge).HasColumnName("CG3Gauge");
            entity.Property(e => e.Cg3length).HasColumnName("CG3Length");
            entity.Property(e => e.Cg3material)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG3Material");
            entity.Property(e => e.Cg3position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG3Position");
            entity.Property(e => e.Cg3qty).HasColumnName("CG3QTY");
            entity.Property(e => e.Cg3width).HasColumnName("CG3Width");
            entity.Property(e => e.Cg4gauge).HasColumnName("CG4Gauge");
            entity.Property(e => e.Cg4length).HasColumnName("CG4Length");
            entity.Property(e => e.Cg4material)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG4Material");
            entity.Property(e => e.Cg4position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG4Position");
            entity.Property(e => e.Cg4qty).HasColumnName("CG4QTY");
            entity.Property(e => e.Cg4width).HasColumnName("CG4Width");
            entity.Property(e => e.Cg5gauge).HasColumnName("CG5Gauge");
            entity.Property(e => e.Cg5length).HasColumnName("CG5Length");
            entity.Property(e => e.Cg5material)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG5Material");
            entity.Property(e => e.Cg5position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG5Position");
            entity.Property(e => e.Cg5qty).HasColumnName("CG5QTY");
            entity.Property(e => e.Cg5width).HasColumnName("CG5Width");
            entity.Property(e => e.Cg6gauge).HasColumnName("CG6Gauge");
            entity.Property(e => e.Cg6length).HasColumnName("CG6Length");
            entity.Property(e => e.Cg6material)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG6Material");
            entity.Property(e => e.Cg6position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CG6Position");
            entity.Property(e => e.Cg6qty).HasColumnName("CG6QTY");
            entity.Property(e => e.Cg6width).HasColumnName("CG6Width");
            entity.Property(e => e.ChildBobbin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChildCclamp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChildCClamp");
            entity.Property(e => e.ChildCore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilRingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSupportSinDoub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsDvdia).HasColumnName("ConsDVDia");
            entity.Property(e => e.ConsDvmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ConsDVMaterial");
            entity.Property(e => e.ConsDvposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ConsDVPosition");
            entity.Property(e => e.ConsDvx).HasColumnName("ConsDVX");
            entity.Property(e => e.ConsDvy).HasColumnName("ConsDVY");
            entity.Property(e => e.ConsRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cooling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreClampMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreGrade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreWindingBracketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CoverAclearance).HasColumnName("CoverAClearance");
            entity.Property(e => e.CoverAgauge).HasColumnName("CoverAGauge");
            entity.Property(e => e.CoverAheight).HasColumnName("CoverAHeight");
            entity.Property(e => e.CoverAmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoverAMaterial");
            entity.Property(e => e.CoverAnutQty).HasColumnName("CoverANutQTY");
            entity.Property(e => e.CoverApos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoverAPos");
            entity.Property(e => e.CoverArodGauge).HasColumnName("CoverARodGauge");
            entity.Property(e => e.CoverArodLength).HasColumnName("CoverARodLength");
            entity.Property(e => e.CoverArodQty).HasColumnName("CoverARodQTY");
            entity.Property(e => e.CoverArodSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoverARodSize");
            entity.Property(e => e.CoverAwidth).HasColumnName("CoverAWidth");
            entity.Property(e => e.CoverBclearance).HasColumnName("CoverBClearance");
            entity.Property(e => e.CoverBgauge).HasColumnName("CoverBGauge");
            entity.Property(e => e.CoverBheight).HasColumnName("CoverBHeight");
            entity.Property(e => e.CoverBmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoverBMaterial");
            entity.Property(e => e.CoverBnutQty).HasColumnName("CoverBNutQTY");
            entity.Property(e => e.CoverBpos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoverBPos");
            entity.Property(e => e.CoverBrodGauge).HasColumnName("CoverBRodGauge");
            entity.Property(e => e.CoverBrodLength).HasColumnName("CoverBRodLength");
            entity.Property(e => e.CoverBrodQty).HasColumnName("CoverBRodQTY");
            entity.Property(e => e.CoverBrodSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CoverBRodSize");
            entity.Property(e => e.CoverBwidth).HasColumnName("CoverBWidth");
            entity.Property(e => e.CoverType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cwimport).HasColumnName("CWImport");
            entity.Property(e => e.CwimportDate)
                .HasColumnType("datetime")
                .HasColumnName("CWImportDate");
            entity.Property(e => e.CwimportSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CWImportSpec");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DesignId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DesignID");
            entity.Property(e => e.DesignNotes).IsUnicode(false);
            entity.Property(e => e.DesignString)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DexVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dove2Shape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveLockBoltMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dovetail2Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DovetailMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValveGaurdQty).HasColumnName("DrainValveGaurdQTY");
            entity.Property(e => e.DrainValveGaurdType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValveMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValvePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Duty)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DvcorkGauge).HasColumnName("DVCorkGauge");
            entity.Property(e => e.DvcorkLength).HasColumnName("DVCorkLength");
            entity.Property(e => e.DvcorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DVCorkMaterial");
            entity.Property(e => e.DvcorkWidth).HasColumnName("DVCorkWidth");
            entity.Property(e => e.EndWrapMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeCsa).HasColumnName("FeCSA");
            entity.Property(e => e.FillerPipeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FillerPipePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPaperMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinTapeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FitNer).HasColumnName("FitNER");
            entity.Property(e => e.FitNerm).HasColumnName("FitNERM");
            entity.Property(e => e.GadrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GADrawingPDF");
            entity.Property(e => e.GlueBoardMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hlduct).HasColumnName("HLDuct");
            entity.Property(e => e.HlductCoilLength).HasColumnName("HLDuctCoilLength");
            entity.Property(e => e.HlductCoilsPerLeg).HasColumnName("HLDuctCoilsPerLeg");
            entity.Property(e => e.HlductHeight).HasColumnName("HLDuctHeight");
            entity.Property(e => e.HlductLayers).HasColumnName("HLDuctLayers");
            entity.Property(e => e.HlductPitch).HasColumnName("HLDuctPitch");
            entity.Property(e => e.HlductType).HasColumnName("HLDuctType");
            entity.Property(e => e.HlinsCoilLength).HasColumnName("HLInsCoilLength");
            entity.Property(e => e.HlinsCoilsPerLeg).HasColumnName("HLInsCoilsPerLeg");
            entity.Property(e => e.HlinsGuage).HasColumnName("HLInsGuage");
            entity.Property(e => e.Hlinsulation).HasColumnName("HLInsulation");
            entity.Property(e => e.HlpaperMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLPaperMaterial");
            entity.Property(e => e.HlspacerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLSpacerMaterial");
            entity.Property(e => e.HlspacersCustom).HasColumnName("HLSpacersCustom");
            entity.Property(e => e.HlspacersMode).HasColumnName("HLSpacersMode");
            entity.Property(e => e.HlwrapsBeforeAfter)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLWrapsBeforeAfter");
            entity.Property(e => e.HlwrapsMode).HasColumnName("HLWrapsMode");
            entity.Property(e => e.HorTieMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpedanceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImportedDate).HasColumnType("datetime");
            entity.Property(e => e.ImportedSpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndoorOutDoor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsulationClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JackingPadQty).HasColumnName("JackingPadQTY");
            entity.Property(e => e.JackingPadType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kvalock).HasColumnName("KVALock");
            entity.Property(e => e.LastModBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadSupportQty).HasColumnName("LeadSupportQTY");
            entity.Property(e => e.LeadSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LiftLugBgauge).HasColumnName("LiftLugBGauge");
            entity.Property(e => e.LiftLugBqty).HasColumnName("LiftLugBQTY");
            entity.Property(e => e.LiftLugBtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LiftLugBType");
            entity.Property(e => e.LiftLugType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimbClamps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimitSwitchQty).HasColumnName("LimitSwitchQTY");
            entity.Property(e => e.LimitSwitchType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lvbil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LVBil");
            entity.Property(e => e.Lveddies).HasColumnName("LVEddies");
            entity.Property(e => e.MarshalBoxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshalBoxPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshallBoxBracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.MountHolePositions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mvbil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MVBil");
            entity.Property(e => e.Nermqty).HasColumnName("NERMQTY");
            entity.Property(e => e.Nermtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NERMType");
            entity.Property(e => e.Nerqty).HasColumnName("NERQTY");
            entity.Property(e => e.Nertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NERType");
            entity.Property(e => e.Odauto).HasColumnName("ODAuto");
            entity.Property(e => e.Odpreset).HasColumnName("ODPreset");
            entity.Property(e => e.OilGuageMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilGuagePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilThermMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilThermPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackingListPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PackingListPDF");
            entity.Property(e => e.Paint)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParentRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pdes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PDES");
            entity.Property(e => e.PhaseBarrierMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pmbenable).HasColumnName("PMBEnable");
            entity.Property(e => e.PoleMountBracketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PowerFreqLv).HasColumnName("PowerFreqLV");
            entity.Property(e => e.PowerFreqMv).HasColumnName("PowerFreqMV");
            entity.Property(e => e.PriBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriCboxEnable).HasColumnName("PriCBoxEnable");
            entity.Property(e => e.PriCboxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PriCBoxMaterial");
            entity.Property(e => e.PriOpenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriPocketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Primer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductRangeId).HasColumnName("ProductRangeID");
            entity.Property(e => e.ProductSpecPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductSpecPDF");
            entity.Property(e => e.Prvdia).HasColumnName("PRVDIA");
            entity.Property(e => e.Prvenable).HasColumnName("PRVEnable");
            entity.Property(e => e.Prvmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVMaterial");
            entity.Property(e => e.Prvmplate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVMPLATE");
            entity.Property(e => e.Prvposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVPosition");
            entity.Property(e => e.Prvx).HasColumnName("PRVX");
            entity.Property(e => e.Prvy).HasColumnName("PRVY");
            entity.Property(e => e.RPerc).HasColumnName("R_Perc");
            entity.Property(e => e.RadAssyPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RadAssyPDF");
            entity.Property(e => e.RangeId).HasColumnName("RangeID");
            entity.Property(e => e.RangeItemId).HasColumnName("RangeItemID");
            entity.Property(e => e.RatingPlateBracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseListPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReleaseListPDF");
            entity.Property(e => e.RevNotes).IsUnicode(false);
            entity.Property(e => e.Rpdepth).HasColumnName("RPDepth");
            entity.Property(e => e.Rpheight).HasColumnName("RPHeight");
            entity.Property(e => e.RplateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RPlateMaterial");
            entity.Property(e => e.RplatePos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RPlatePos");
            entity.Property(e => e.Rpwidth).HasColumnName("RPWidth");
            entity.Property(e => e.Rpx).HasColumnName("RPX");
            entity.Property(e => e.Rpy).HasColumnName("RPY");
            entity.Property(e => e.Sales).HasColumnType("money");
            entity.Property(e => e.SaveVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScreenLeadsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScreenLeadsPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScreenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScreensMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ScreensQty).HasColumnName("ScreensQTY");
            entity.Property(e => e.SecBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecCboxEnable).HasColumnName("SecCBoxEnable");
            entity.Property(e => e.SecCboxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SecCBoxMaterial");
            entity.Property(e => e.SecOpenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecPocketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecBase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecColour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecDesc)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.SpecInput)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecOutput)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecProjectDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SpecSpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecTaps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecVector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Standard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardCclamp).HasColumnName("StandardCClamp");
            entity.Property(e => e.StiffenerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubAssyId).HasColumnName("SubAssyID");
            entity.Property(e => e.TankAssyPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TankAssyPDF");
            entity.Property(e => e.TankLabelsPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TankLabelsPDF");
            entity.Property(e => e.TankRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankrimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TapeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tbclearance).HasColumnName("TBClearance");
            entity.Property(e => e.TbdrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBDrawingPDF");
            entity.Property(e => e.TblabelPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBLabelPDF");
            entity.Property(e => e.TbmountNutQty).HasColumnName("TBMountNutQTY");
            entity.Property(e => e.TbmountRodLength).HasColumnName("TBMountRodLength");
            entity.Property(e => e.TbmountRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBMountRodMaterial");
            entity.Property(e => e.TbmountingRodGauge).HasColumnName("TBMountingRodGauge");
            entity.Property(e => e.TbmountingRodQty).HasColumnName("TBMountingRodQTY");
            entity.Property(e => e.TboardBclearance).HasColumnName("TBoardBClearance");
            entity.Property(e => e.TboardBgauge).HasColumnName("TBoardBGauge");
            entity.Property(e => e.TboardBheight).HasColumnName("TBoardBHeight");
            entity.Property(e => e.TboardBmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardBMaterial");
            entity.Property(e => e.TboardBnutQty).HasColumnName("TBoardBNutQTY");
            entity.Property(e => e.TboardBpos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardBPos");
            entity.Property(e => e.TboardBrodGauge).HasColumnName("TBoardBRodGauge");
            entity.Property(e => e.TboardBrodLength).HasColumnName("TBoardBRodLength");
            entity.Property(e => e.TboardBrodQty).HasColumnName("TBoardBRodQTY");
            entity.Property(e => e.TboardBrodSize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardBRodSize");
            entity.Property(e => e.TboardBwidth).HasColumnName("TBoardBWidth");
            entity.Property(e => e.TboardDepth).HasColumnName("TBoardDepth");
            entity.Property(e => e.TboardMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardMaterial");
            entity.Property(e => e.TboardPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardPos");
            entity.Property(e => e.TboardThickness).HasColumnName("TBoardThickness");
            entity.Property(e => e.TboardWidth).HasColumnName("TBoardWidth");
            entity.Property(e => e.Term1Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term2Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term3Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term4Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Testdatapdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TESTDATAPDF");
            entity.Property(e => e.ThermPocketPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThermPocketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Thinners)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TmpBreatherEnable).HasColumnName("tmpBreatherEnable");
            entity.Property(e => e.TmpBucholtzEnable).HasColumnName("tmpBucholtzEnable");
            entity.Property(e => e.TmpConsDrainEnable).HasColumnName("tmpConsDrainEnable");
            entity.Property(e => e.TmpDrainEnable).HasColumnName("tmpDrainEnable");
            entity.Property(e => e.TmpFillerEnable).HasColumnName("tmpFillerEnable");
            entity.Property(e => e.TmpOilGuageEnable).HasColumnName("tmpOilGuageEnable");
            entity.Property(e => e.TmpOilThermEnable).HasColumnName("tmpOilThermEnable");
            entity.Property(e => e.TmpPriCboxEnable).HasColumnName("tmpPriCBoxEnable");
            entity.Property(e => e.TmpPriPocketEnable).HasColumnName("tmpPriPocketEnable");
            entity.Property(e => e.TmpSecCboxEnable).HasColumnName("tmpSecCBoxEnable");
            entity.Property(e => e.TmpSecPocketEnable).HasColumnName("tmpSecPocketEnable");
            entity.Property(e => e.TmpTankSkidsEnable).HasColumnName("tmpTankSkidsEnable");
            entity.Property(e => e.TmpTapSwitchEnable).HasColumnName("tmpTapSwitchEnable");
            entity.Property(e => e.TotalVa).HasColumnName("TotalVA");
            entity.Property(e => e.TswitchBossDia).HasColumnName("TSwitchBossDia");
            entity.Property(e => e.TswitchBossMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSwitchBossMaterial");
            entity.Property(e => e.TswitchBossPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSwitchBossPos");
            entity.Property(e => e.TswitchBossX).HasColumnName("TSwitchBossX");
            entity.Property(e => e.TswitchBossY).HasColumnName("TSwitchBossY");
            entity.Property(e => e.TswitchHolY).HasColumnName("TSwitchHolY");
            entity.Property(e => e.TswitchHoleCentre).HasColumnName("TSwitchHoleCentre");
            entity.Property(e => e.TswitchHoleDia).HasColumnName("TSwitchHoleDia");
            entity.Property(e => e.TswitchHoleX).HasColumnName("TSwitchHoleX");
            entity.Property(e => e.Varange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VARange");
            entity.Property(e => e.VerTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieStyle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WedgeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WheelsId).HasColumnName("WheelsID");
            entity.Property(e => e.WheelsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WheelsOd).HasColumnName("WheelsOD");
            entity.Property(e => e.WheelsQty).HasColumnName("WheelsQTY");
            entity.Property(e => e.WindingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WindingSpecNotes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WperKg).HasColumnName("WperKG");
            entity.Property(e => e.Wtienable).HasColumnName("WTIEnable");
            entity.Property(e => e.Wtiqty).HasColumnName("WTIQTY");
            entity.Property(e => e.Wtitype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WTIType");
            entity.Property(e => e.XPerc).HasColumnName("X_Perc");
            entity.Property(e => e.ZPerc).HasColumnName("Z_Perc");
            entity.Property(e => e.ZpercLock).HasColumnName("ZPercLock");
        });

        modelBuilder.Entity<DesignParameters>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("Design_Parameters");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.ParamCaption)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParamTable)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParamValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RangeId).HasColumnName("RangeID");
        });

        modelBuilder.Entity<DesignRadiators>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_Radiators");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073636").IsClustered();

            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RadType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardRad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TubeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Oval");
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignRads>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("design_rads");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo, e.No }, "ClusteredIndex-20230729-073655").IsClustered();

            entity.Property(e => e.BottomBoxShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartRange)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sqlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SQLID");
            entity.Property(e => e.TopBoxShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TubeType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignRadsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_Rads_old");

            entity.Property(e => e.BottomBoxShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartRange)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sqlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SQLID");
            entity.Property(e => e.TopBoxShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TubeType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignRangeExclusions>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo, e.PropertyType });

            entity.ToTable("Design_RangeExclusions");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropertyType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropertyName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PropertyValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RangeId).HasColumnName("RangeID");
        });

        modelBuilder.Entity<DesignReactanceData>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo });

            entity.ToTable("Design_ReactanceData");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.C1AmpsLine).HasColumnName("c1Amps_line");
            entity.Property(e => e.C1AmpsPhase).HasColumnName("c1Amps_phase");
            entity.Property(e => e.C1Id1).HasColumnName("c1ID1");
            entity.Property(e => e.C1Id2).HasColumnName("c1ID2");
            entity.Property(e => e.C1Length).HasColumnName("c1Length");
            entity.Property(e => e.C1Mlt).HasColumnName("c1MLT");
            entity.Property(e => e.C1Od1).HasColumnName("c1OD1");
            entity.Property(e => e.C1Od2).HasColumnName("c1OD2");
            entity.Property(e => e.C1Radial).HasColumnName("c1Radial");
            entity.Property(e => e.C1TurnsNom).HasColumnName("c1Turns_nom");
            entity.Property(e => e.C1Vector).HasColumnName("c1Vector");
            entity.Property(e => e.C1VoltsLine).HasColumnName("c1Volts_line");
            entity.Property(e => e.C1VoltsPhase).HasColumnName("c1Volts_phase");
            entity.Property(e => e.C2AmpsLine).HasColumnName("c2Amps_line");
            entity.Property(e => e.C2AmpsPhase).HasColumnName("c2Amps_phase");
            entity.Property(e => e.C2Id1).HasColumnName("c2ID1");
            entity.Property(e => e.C2Id2).HasColumnName("c2ID2");
            entity.Property(e => e.C2Length).HasColumnName("c2Length");
            entity.Property(e => e.C2Mlt).HasColumnName("c2MLT");
            entity.Property(e => e.C2Od1).HasColumnName("c2OD1");
            entity.Property(e => e.C2Od2).HasColumnName("c2OD2");
            entity.Property(e => e.C2Radial).HasColumnName("c2Radial");
            entity.Property(e => e.C2TurnsNom).HasColumnName("c2Turns_nom");
            entity.Property(e => e.C2Vector).HasColumnName("c2Vector");
            entity.Property(e => e.C2VoltsLine).HasColumnName("c2Volts_line");
            entity.Property(e => e.C2VoltsPhase).HasColumnName("c2Volts_phase");
            entity.Property(e => e.HlId1).HasColumnName("hlID1");
            entity.Property(e => e.HlId2).HasColumnName("hlID2");
            entity.Property(e => e.HlMlt).HasColumnName("hlMLT");
            entity.Property(e => e.HlOd1).HasColumnName("hlOD1");
            entity.Property(e => e.HlOd2).HasColumnName("hlOD2");
            entity.Property(e => e.HlRadial).HasColumnName("hlRadial");
            entity.Property(e => e.NominalVa).HasColumnName("NominalVA");
            entity.Property(e => e.Vt).HasColumnName("VT");
        });

        modelBuilder.Entity<DesignRibs>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo, e.RibNo });

            entity.ToTable("Design_Ribs");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RibMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RibPosName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RibShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignStepCores>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_StepCores");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073912").IsClustered();

            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignTanks>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_Tanks");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-073932").IsClustered();

            entity.Property(e => e.CboxCount).HasColumnName("CBoxCount");
            entity.Property(e => e.Construction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CrossBraceMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CrossBraceProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaintClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaintMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PaintType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerThinnersMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrimerType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RibPosName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SelectedTankBase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankBaseMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankBaseType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TankBracketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankBracketProfile)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankCboxThick).HasColumnName("TankCBoxThick");
            entity.Property(e => e.TankLidMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankRimCorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankSkidsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankSkidsShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankSlotsType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TankTypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TankWallMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tfbottom).HasColumnName("TFBottom");
            entity.Property(e => e.Tfguage).HasColumnName("TFGuage");
            entity.Property(e => e.Tfheight).HasColumnName("TFHeight");
            entity.Property(e => e.Tfholes).HasColumnName("TFHoles");
            entity.Property(e => e.TfslotHeight).HasColumnName("TFSlotHeight");
            entity.Property(e => e.TfslotWidth).HasColumnName("TFSlotWidth");
            entity.Property(e => e.Tftop).HasColumnName("TFTop");
            entity.Property(e => e.ThinnersMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.VentBoxType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VentboxBasePaint)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignTaps>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo, e.PriSec, e.WindingNo, e.TapNo });

            entity.ToTable("Design_Taps");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clength).HasColumnName("CLength");
            entity.Property(e => e.ConCsa).HasColumnName("ConCSA");
            entity.Property(e => e.DuctsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DuctsString)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EdgeStripsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndDovetailMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterLayerInsAfterQty).HasColumnName("InterLayerInsAfterQTY");
            entity.Property(e => e.InterLayerInsAfterType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InterLayerInsAfterTYpe");
            entity.Property(e => e.InterLayerInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KeyDovetailMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadColour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadSupportMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadSupportQtypc).HasColumnName("LeadSupportQTYPC");
            entity.Property(e => e.Leads)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LugsBmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LugsBMaterial");
            entity.Property(e => e.LugsBqty).HasColumnName("LugsBQty");
            entity.Property(e => e.LugsTmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LugsTMaterial");
            entity.Property(e => e.LugsTqty).HasColumnName("LugsTQty");
            entity.Property(e => e.SowductsCoolingSurface)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOWDuctsCoolingSurface");
            entity.Property(e => e.SowductsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOWDuctsMaterial");
            entity.Property(e => e.SowductsPitch).HasColumnName("SOWDuctsPitch");
            entity.Property(e => e.SowductsQty).HasColumnName("SOWDuctsQTY");
            entity.Property(e => e.SowductsSize).HasColumnName("SOWDuctsSize");
            entity.Property(e => e.SowinsGauge).HasColumnName("SOWInsGauge");
            entity.Property(e => e.SowinsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOWInsMaterial");
            entity.Property(e => e.SowinsThickness).HasColumnName("SOWInsThickness");
            entity.Property(e => e.SowinsWraps).HasColumnName("SOWInsWraps");
            entity.Property(e => e.TapBreakMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Txposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TXPosition");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.WindFunction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WireCost).HasColumnType("money");
            entity.Property(e => e.WireCovering)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignTestGroupDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_TestGroupDetail");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-074008").IsClustered();

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.PriSec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WindingName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignTestGroups>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.ToTable("Design_TestGroups");

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignTestResults>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Design_TestResults");

            entity.HasIndex(e => new { e.SpecNo, e.RevNo }, "ClusteredIndex-20230729-074048").IsClustered();

            entity.Property(e => e.AmpsLv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AmpsLV");
            entity.Property(e => e.AmpsMv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AmpsMV");
            entity.Property(e => e.Cooling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FilePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Filename)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Frequency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsCe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsCE");
            entity.Property(e => e.InsLve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsLVE");
            entity.Property(e => e.InsMve)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsMVE");
            entity.Property(e => e.InsMvlv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsMVLV");
            entity.Property(e => e.InsScre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsSCRE");
            entity.Property(e => e.InsScrlv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsSCRLV");
            entity.Property(e => e.InsScrmv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsSCRMV");
            entity.Property(e => e.LlI)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_I");
            entity.Property(e => e.LlI2r)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_I2R");
            entity.Property(e => e.LlImpedance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Impedance");
            entity.Property(e => e.LlPf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_PF");
            entity.Property(e => e.LlPower)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Power");
            entity.Property(e => e.LlReactance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Reactance");
            entity.Property(e => e.LlResistance)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Resistance");
            entity.Property(e => e.LlStrays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Strays");
            entity.Property(e => e.LlTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Temp");
            entity.Property(e => e.LlV)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_V");
            entity.Property(e => e.LlWatts)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LL_Watts");
            entity.Property(e => e.NllCoreMass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_CoreMass");
            entity.Property(e => e.NllCoreType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_CoreType");
            entity.Property(e => e.NllI)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_I");
            entity.Property(e => e.NllPf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_PF");
            entity.Property(e => e.NllPower)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_Power");
            entity.Property(e => e.NllQuoted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_Quoted");
            entity.Property(e => e.NllV)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_V");
            entity.Property(e => e.NllWCorr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_W_Corr");
            entity.Property(e => e.NllWkg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NLL_WKG");
            entity.Property(e => e.OrderNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio1Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio2Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio3Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio4Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio5Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio6Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7A)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7AmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7B)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7BmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7C)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7CmA)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7Perc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ratio7Reqd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RecID");
            entity.Property(e => e.SerialNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WrLAb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_L_AB");
            entity.Property(e => e.WrLAbc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_L_ABC");
            entity.Property(e => e.WrLAc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_L_AC");
            entity.Property(e => e.WrLBc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_L_BC");
            entity.Property(e => e.WrLUnits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_L_Units");
            entity.Property(e => e.WrLV)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_L_V");
            entity.Property(e => e.WrNAb)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_N_AB");
            entity.Property(e => e.WrNAbc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_N_ABC");
            entity.Property(e => e.WrNAc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_N_AC");
            entity.Property(e => e.WrNBc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_N_BC");
            entity.Property(e => e.WrNUnits)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_N_Units");
            entity.Property(e => e.WrNV)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_N_V");
            entity.Property(e => e.WrP1Ab)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_P1_AB");
            entity.Property(e => e.WrP1Abc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_P1_ABC");
            entity.Property(e => e.WrP1Ac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_P1_AC");
            entity.Property(e => e.WrP1Bc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_P1_BC");
            entity.Property(e => e.WrP1Units)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_P1_Units");
            entity.Property(e => e.WrP1V)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_P1_V");
            entity.Property(e => e.WrTemp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WR_Temp");
        });

        modelBuilder.Entity<DesignUnlock>(entity =>
        {
            entity.ToTable("Design_Unlock");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Designer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ncrno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NCRNo");
            entity.Property(e => e.Reason).IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesignWindings>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo, e.PriSec, e.WindingNo });

            entity.ToTable("Design_Windings");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<DesignWire>(entity =>
        {
            entity.HasKey(e => new { e.SpecNo, e.RevNo, e.PriSec, e.WindingNo, e.TapNo, e.StrandNo });

            entity.ToTable("Design_Wire");

            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Cucsa).HasColumnName("CUCSA");
            entity.Property(e => e.Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sqlid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SQLID");
            entity.Property(e => e.WireIdno).HasColumnName("WireIDNo");
            entity.Property(e => e.WireInsX).HasDefaultValue(0.0);
            entity.Property(e => e.WireInsY).HasDefaultValue(0.0);
            entity.Property(e => e.Xpos).HasColumnName("XPos");
            entity.Property(e => e.Ypos).HasColumnName("YPos");
        });

        modelBuilder.Entity<DesignWireBak>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEsign_wire_bak");

            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WireIdno).HasColumnName("WireIDNo");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.RecId);

            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ErrorClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SenderClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobPartsUsedLog>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Output)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProfilingJob>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CompletedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompletedDate).HasColumnType("datetime");
            entity.Property(e => e.ComponentMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComponentName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ComponentQty).HasColumnName("ComponentQTY");
            entity.Property(e => e.ComponentStockCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DelDate).HasColumnType("datetime");
            entity.Property(e => e.Destination)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrawingScheduleId).HasColumnName("DrawingScheduleID");
            entity.Property(e => e.JobNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ManuQty).HasColumnName("ManuQTY");
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.OrderQty).HasColumnName("Order QTY");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProjectInUse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RtenquiryDesign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RTEnquiryDesign");

            entity.Property(e => e.Altitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cooling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Costing).HasColumnType("money");
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.DesignId).HasColumnName("DesignID");
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Enclosure)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpedanceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndoorOutDoor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsulationClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastOrder).HasColumnType("datetime");
            entity.Property(e => e.LastOrderId).HasColumnName("LastOrderID");
            entity.Property(e => e.LastOrderPrice).HasColumnType("money");
            entity.Property(e => e.LastQuote).HasColumnType("datetime");
            entity.Property(e => e.LastQuoteId).HasColumnName("LastQuoteID");
            entity.Property(e => e.LastQuotePrice).HasColumnType("money");
            entity.Property(e => e.Moddate).HasColumnType("datetime");
            entity.Property(e => e.OilType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderAccNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderCustomer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.OrderPrice).HasColumnType("money");
            entity.Property(e => e.Pmbenable).HasColumnName("PMBEnable");
            entity.Property(e => e.Prvenable).HasColumnName("PRVEnable");
            entity.Property(e => e.QuoteAccNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QuoteCustomer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.QuoteDate).HasColumnType("datetime");
            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            entity.Property(e => e.QuotePrice).HasColumnType("money");
            entity.Property(e => e.RevNotes).IsUnicode(false);
            entity.Property(e => e.SpecBase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecColour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecTaps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecVector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalVa).HasColumnName("TotalVA");
            entity.Property(e => e.WindingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempBobbins>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_BOBBINS");

            entity.Property(e => e.BobbinLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinProductId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BobbinProductID");
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FlangeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempBom>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_BOM");

            entity.Property(e => e.Cost6)
                .HasColumnType("money")
                .HasColumnName("Cost_6");
            entity.Property(e => e.Cpa8)
                .HasColumnType("money")
                .HasColumnName("CPA_8");
            entity.Property(e => e.Description2)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Description_2");
            entity.Property(e => e.DexPart0)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DexPart_0");
            entity.Property(e => e.EnvisageRef12).HasColumnName("EnvisageRef_12");
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductId3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ProductID_3");
            entity.Property(e => e.Qty4).HasColumnName("Qty_4");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardUnits11)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Standard_Units_11");
            entity.Property(e => e.TotalAmount9)
                .HasColumnType("money")
                .HasColumnName("TotalAmount_9");
            entity.Property(e => e.Units5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Units_5");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.Waste7).HasColumnName("Waste_7");
        });

        modelBuilder.Entity<TempCablebox>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CABLEBOX");

            entity.Property(e => e.BushingOutsideLength).HasColumnName("BushingOutsideLEngth");
            entity.Property(e => e.CboxLidType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CBoxLidType");
            entity.Property(e => e.CboxRimBoltPitch).HasColumnName("CBoxRimBoltPitch");
            entity.Property(e => e.CboxRimBoltQty).HasColumnName("CBoxRimBoltQTY");
            entity.Property(e => e.CboxRimBoltSpec)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBoxRimBoltSpec");
            entity.Property(e => e.GlandPlateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndoorBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OutdoorBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardBox)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardPocket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stdcbox).HasColumnName("STDCBox");
            entity.Property(e => e.Stdpocket).HasColumnName("STDPocket");
            entity.Property(e => e.TermPlateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempConservators>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CONSERVATORS");

            entity.Property(e => e.ConsStandard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempCoreclamps>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CORECLAMPS");

            entity.Property(e => e.BftoEdge).HasColumnName("BFToEdge");
            entity.Property(e => e.CclampId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampID");
            entity.Property(e => e.CclampLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampLabel");
            entity.Property(e => e.CoilSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSuppShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSupportSinDoub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreClampMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutOutSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveLockBoltMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FramePos)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FrameSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MountHolePositions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardCclamp).HasColumnName("StandardCClamp");
            entity.Property(e => e.StiffenerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TswitchHolY).HasColumnName("TSwitchHolY");
            entity.Property(e => e.TswitchHoleCentre).HasColumnName("TSwitchHoleCentre");
            entity.Property(e => e.TswitchHoleDia).HasColumnName("TSwitchHoleDia");
            entity.Property(e => e.TswitchHoleX).HasColumnName("TSwitchHoleX");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.VerTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieRodMaterial1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieStyle)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempCores>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_CORES");

            entity.Property(e => e.BobbinLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BobbinProductId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BobbinProductID");
            entity.Property(e => e.BobbinRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CclampRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampRef");
            entity.Property(e => e.ChildBobbins)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChildCclamps)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChildCClamps");
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Corename)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeCsa).HasColumnName("FeCSA");
            entity.Property(e => e.FlangeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FormerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LamsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimbClamps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.VentbRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WattsPerKg).HasColumnName("WattsPerKG");
            entity.Property(e => e.WedgeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempJobhistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_JOBHISTORY");

            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER");
            entity.Property(e => e.Envcosting)
                .HasColumnType("money")
                .HasColumnName("ENVCOSTING");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Jobno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JOBNO");
            entity.Property(e => e.Publishdate)
                .HasColumnType("datetime")
                .HasColumnName("PUBLISHDATE");
            entity.Property(e => e.Publishedby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHEDBY");
            entity.Property(e => e.Revno).HasColumnName("REVNO");
            entity.Property(e => e.Specno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SPECNO");
        });

        modelBuilder.Entity<TempLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_LOG");

            entity.Property(e => e.CheckedInOut)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Checked In/Out");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_MAIN");

            entity.Property(e => e.Altitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssemblySpecPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssemblySpecPDF");
            entity.Property(e => e.AuxWiringType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AxleMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BftoEdge).HasColumnName("BFToEdge");
            entity.Property(e => e.BreatherMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BreatherPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BucholtzCodia).HasColumnName("BucholtzCODIA");
            entity.Property(e => e.BucholtzCox).HasColumnName("BucholtzCOX");
            entity.Property(e => e.BucholtzCoy).HasColumnName("BucholtzCOY");
            entity.Property(e => e.BucholtzMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CableRailBgauge).HasColumnName("CableRailBGauge");
            entity.Property(e => e.CableRailBqty).HasColumnName("CableRailBQTY");
            entity.Property(e => e.CableRailBtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CableRailBType");
            entity.Property(e => e.CableRailQty).HasColumnName("CableRailQTY");
            entity.Property(e => e.CableRailType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CclampAssyDrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampAssyDrawingPDF");
            entity.Property(e => e.CclampDrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampDrawingPDF");
            entity.Property(e => e.CclampId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampID");
            entity.Property(e => e.CclampLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampLabel");
            entity.Property(e => e.ChildBobbin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChildCclamp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChildCClamp");
            entity.Property(e => e.ChildCore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilRingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSupportSinDoub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsCorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cooling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreClampMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreGrade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreWindingBracketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CoverType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesignNotes).IsUnicode(false);
            entity.Property(e => e.DesignString)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DexVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveLockBoltMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DovetailMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValveGaurdQty).HasColumnName("DrainValveGaurdQTY");
            entity.Property(e => e.DrainValveGaurdType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValveMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValvePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndWrapMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeCsa).HasColumnName("FeCSA");
            entity.Property(e => e.FillerPipeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FillerPipePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPaperMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinTapeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FitNer).HasColumnName("FitNER");
            entity.Property(e => e.FitNerm).HasColumnName("FitNERM");
            entity.Property(e => e.GadrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GADrawingPDF");
            entity.Property(e => e.GlueBoardMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hlduct).HasColumnName("HLDuct");
            entity.Property(e => e.HlductType).HasColumnName("HLDuctType");
            entity.Property(e => e.HlinsGuage).HasColumnName("HLInsGuage");
            entity.Property(e => e.Hlinsulation).HasColumnName("HLInsulation");
            entity.Property(e => e.HlpaperMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLPaperMaterial");
            entity.Property(e => e.HlspacerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLSpacerMaterial");
            entity.Property(e => e.HorTieMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpedanceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImportedDate).HasColumnType("datetime");
            entity.Property(e => e.ImportedSpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndoorOutDoor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsulationClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JackingPadQty).HasColumnName("JackingPadQTY");
            entity.Property(e => e.JackingPadType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kvalock).HasColumnName("KVALock");
            entity.Property(e => e.LeadSupportQty).HasColumnName("LeadSupportQTY");
            entity.Property(e => e.LeadSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LiftLugBgauge).HasColumnName("LiftLugBGauge");
            entity.Property(e => e.LiftLugBqty).HasColumnName("LiftLugBQTY");
            entity.Property(e => e.LiftLugBtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LiftLugBType");
            entity.Property(e => e.LiftLugType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimbClamps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimitSwitchQty).HasColumnName("LimitSwitchQTY");
            entity.Property(e => e.LimitSwitchType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lvbil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LVBil");
            entity.Property(e => e.Lveddies).HasColumnName("LVEddies");
            entity.Property(e => e.MainTankCorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshalBoxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshalBoxPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshallBoxBracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.MountHolePositions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mvbil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MVBil");
            entity.Property(e => e.Nermqty).HasColumnName("NERMQTY");
            entity.Property(e => e.Nermtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NERMType");
            entity.Property(e => e.Nerqty).HasColumnName("NERQTY");
            entity.Property(e => e.Nertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NERType");
            entity.Property(e => e.Odpreset).HasColumnName("ODPreset");
            entity.Property(e => e.OilGuageMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilGuagePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilThermMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilThermPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackingListPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PackingListPDF");
            entity.Property(e => e.ParentRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pdes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PDES");
            entity.Property(e => e.PhaseBarrierMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pmbenable).HasColumnName("PMBEnable");
            entity.Property(e => e.PoleMountBracketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriCboxEnable).HasColumnName("PriCBoxEnable");
            entity.Property(e => e.PriCboxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PriCBoxMaterial");
            entity.Property(e => e.PriOpenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriPocketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab1Qty).HasColumnName("PriSideLab1QTY");
            entity.Property(e => e.PriSideLab2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab2Qty).HasColumnName("PriSideLab2QTY");
            entity.Property(e => e.PriSideLab3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab3Qty).HasColumnName("PriSideLab3QTY");
            entity.Property(e => e.PriSideLab4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab4Qty).HasColumnName("PriSideLab4QTY");
            entity.Property(e => e.PriSideLab5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab5Qty).HasColumnName("PriSideLab5QTY");
            entity.Property(e => e.PriSideLab6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab6Qty).HasColumnName("PriSideLab6QTY");
            entity.Property(e => e.ProductSpecPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductSpecPDF");
            entity.Property(e => e.Prvdia).HasColumnName("PRVDIA");
            entity.Property(e => e.Prvenable).HasColumnName("PRVEnable");
            entity.Property(e => e.Prvmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVMaterial");
            entity.Property(e => e.Prvmplate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVMPLATE");
            entity.Property(e => e.Prvposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVPosition");
            entity.Property(e => e.Prvx).HasColumnName("PRVX");
            entity.Property(e => e.Prvy).HasColumnName("PRVY");
            entity.Property(e => e.RadAssyPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RadAssyPDF");
            entity.Property(e => e.RangeId).HasColumnName("RangeID");
            entity.Property(e => e.RangeItemId).HasColumnName("RangeItemID");
            entity.Property(e => e.RatingPlateBracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseListPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReleaseListPDF");
            entity.Property(e => e.Rpdepth).HasColumnName("RPDepth");
            entity.Property(e => e.Rpheight).HasColumnName("RPHeight");
            entity.Property(e => e.RplateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RPlateMaterial");
            entity.Property(e => e.RplatePos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RPlatePos");
            entity.Property(e => e.Rpwidth).HasColumnName("RPWidth");
            entity.Property(e => e.Rpx).HasColumnName("RPX");
            entity.Property(e => e.Rpy).HasColumnName("RPY");
            entity.Property(e => e.Sales).HasColumnType("money");
            entity.Property(e => e.SaveVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecCboxEnable).HasColumnName("SecCBoxEnable");
            entity.Property(e => e.SecCboxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SecCBoxMaterial");
            entity.Property(e => e.SecOpenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecPocketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab1Qty).HasColumnName("SecSideLab1QTY");
            entity.Property(e => e.SecSideLab2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab2Qty).HasColumnName("SecSideLab2QTY");
            entity.Property(e => e.SecSideLab3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab3Qty).HasColumnName("SecSideLab3QTY");
            entity.Property(e => e.SecSideLab4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab4Qty).HasColumnName("SecSideLab4QTY");
            entity.Property(e => e.SecSideLab5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab5Qty).HasColumnName("SecSideLab5QTY");
            entity.Property(e => e.SecSideLab6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab6Qty).HasColumnName("SecSideLab6QTY");
            entity.Property(e => e.SpecBase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecColour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecDesc)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.SpecInput)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecOutput)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecProjectDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SpecSpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecTaps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecVector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Standard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardCclamp).HasColumnName("StandardCClamp");
            entity.Property(e => e.StiffenerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankAssyPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TankAssyPDF");
            entity.Property(e => e.TankLabelsPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TankLabelsPDF");
            entity.Property(e => e.TankRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankrimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TapeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TbdrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBDrawingPDF");
            entity.Property(e => e.TblabelPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBLabelPDF");
            entity.Property(e => e.TboardDepth).HasColumnName("TBoardDepth");
            entity.Property(e => e.TboardMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardMaterial");
            entity.Property(e => e.TboardPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardPos");
            entity.Property(e => e.TboardThickness).HasColumnName("TBoardThickness");
            entity.Property(e => e.TboardWidth).HasColumnName("TBoardWidth");
            entity.Property(e => e.Term1Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term2Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term3Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term4Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Testdatapdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TESTDATAPDF");
            entity.Property(e => e.ThermPocketPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThermPocketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TmpBreatherEnable).HasColumnName("tmpBreatherEnable");
            entity.Property(e => e.TmpBucholtzEnable).HasColumnName("tmpBucholtzEnable");
            entity.Property(e => e.TmpDrainEnable).HasColumnName("tmpDrainEnable");
            entity.Property(e => e.TmpFillerEnable).HasColumnName("tmpFillerEnable");
            entity.Property(e => e.TmpOilGuageEnable).HasColumnName("tmpOilGuageEnable");
            entity.Property(e => e.TmpOilThermEnable).HasColumnName("tmpOilThermEnable");
            entity.Property(e => e.TmpPriCboxEnable).HasColumnName("tmpPriCBoxEnable");
            entity.Property(e => e.TmpPriPocketEnable).HasColumnName("tmpPriPocketEnable");
            entity.Property(e => e.TmpSecCboxEnable).HasColumnName("tmpSecCBoxEnable");
            entity.Property(e => e.TmpSecPocketEnable).HasColumnName("tmpSecPocketEnable");
            entity.Property(e => e.TmpTankSkidsEnable).HasColumnName("tmpTankSkidsEnable");
            entity.Property(e => e.TmpTapSwitchEnable).HasColumnName("tmpTapSwitchEnable");
            entity.Property(e => e.TotalVa).HasColumnName("TotalVA");
            entity.Property(e => e.TswitchBossDia).HasColumnName("TSwitchBossDia");
            entity.Property(e => e.TswitchBossMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSwitchBossMaterial");
            entity.Property(e => e.TswitchBossPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSwitchBossPos");
            entity.Property(e => e.TswitchBossX).HasColumnName("TSwitchBossX");
            entity.Property(e => e.TswitchBossY).HasColumnName("TSwitchBossY");
            entity.Property(e => e.TswitchHolY).HasColumnName("TSwitchHolY");
            entity.Property(e => e.TswitchHoleCentre).HasColumnName("TSwitchHoleCentre");
            entity.Property(e => e.TswitchHoleDia).HasColumnName("TSwitchHoleDia");
            entity.Property(e => e.TswitchHoleX).HasColumnName("TSwitchHoleX");
            entity.Property(e => e.Varange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VARange");
            entity.Property(e => e.VerTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieStyle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WedgeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WheelsId).HasColumnName("WheelsID");
            entity.Property(e => e.WheelsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WheelsOd).HasColumnName("WheelsOD");
            entity.Property(e => e.WheelsQty).HasColumnName("WheelsQTY");
            entity.Property(e => e.WindingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WindingSpecNotes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WperKg).HasColumnName("WperKG");
            entity.Property(e => e.Wtienable).HasColumnName("WTIEnable");
        });

        modelBuilder.Entity<TempRadiators>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_RADIATORS");

            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardRad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempRibs>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_RIBS");

            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RibPosName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempStepcores>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_STEPCORES");

            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempTable");

            entity.Property(e => e.Accessory)
                .HasMaxLength(24)
                .IsUnicode(false);
            entity.Property(e => e.BushingCosting).HasColumnType("money");
            entity.Property(e => e.BushingProdId)
                .HasMaxLength(50)
                .HasColumnName("BushingProdID");
            entity.Property(e => e.BushingQty).HasColumnName("BushingQTY");
            entity.Property(e => e.BushingTotalCost).HasColumnType("money");
            entity.Property(e => e.Costing).HasColumnType("money");
            entity.Property(e => e.Cst)
                .HasColumnType("money")
                .HasColumnName("cst");
            entity.Property(e => e.FlagName).HasMaxLength(128);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.ProductId)
                .HasMaxLength(50)
                .HasColumnName("ProductID");
            entity.Property(e => e.RangeItemId).HasColumnName("RangeItemID");
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAccCosting).HasColumnType("money");
            entity.Property(e => e.TotalCost).HasColumnType("money");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempTable1>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Altitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AssemblySpecPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AssemblySpecPDF");
            entity.Property(e => e.AuxWiringType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AxleMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BftoEdge).HasColumnName("BFToEdge");
            entity.Property(e => e.BreatherMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BreatherPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BucholtzCodia).HasColumnName("BucholtzCODIA");
            entity.Property(e => e.BucholtzCox).HasColumnName("BucholtzCOX");
            entity.Property(e => e.BucholtzCoy).HasColumnName("BucholtzCOY");
            entity.Property(e => e.BucholtzMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CableRailBgauge).HasColumnName("CableRailBGauge");
            entity.Property(e => e.CableRailBqty).HasColumnName("CableRailBQTY");
            entity.Property(e => e.CableRailBtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CableRailBType");
            entity.Property(e => e.CableRailQty).HasColumnName("CableRailQTY");
            entity.Property(e => e.CableRailType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CclampAssyDrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampAssyDrawingPDF");
            entity.Property(e => e.CclampDrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampDrawingPDF");
            entity.Property(e => e.CclampId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampID");
            entity.Property(e => e.CclampLabel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CClampLabel");
            entity.Property(e => e.ChildBobbin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChildCclamp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ChildCClamp");
            entity.Property(e => e.ChildCore)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilRingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSuppMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoilSupportSinDoub)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsCorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ConsRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cooling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreClampMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreFeetSpec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreGrade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreWindingBracketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cost).HasColumnType("money");
            entity.Property(e => e.CoverType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CutSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesignNotes).IsUnicode(false);
            entity.Property(e => e.DesignString)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Device)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DexVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveLockBoltMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DoveShape)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DovetailMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValveGaurdQty).HasColumnName("DrainValveGaurdQTY");
            entity.Property(e => e.DrainValveGaurdType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValveMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DrainValvePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndWrapMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeCsa).HasColumnName("FeCSA");
            entity.Property(e => e.FillerPipeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FillerPipePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinPaperMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FinTapeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FitNer).HasColumnName("FitNER");
            entity.Property(e => e.FitNerm).HasColumnName("FitNERM");
            entity.Property(e => e.GadrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GADrawingPDF");
            entity.Property(e => e.GlueBoardMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Hlduct).HasColumnName("HLDuct");
            entity.Property(e => e.HlductType).HasColumnName("HLDuctType");
            entity.Property(e => e.HlinsGuage).HasColumnName("HLInsGuage");
            entity.Property(e => e.Hlinsulation).HasColumnName("HLInsulation");
            entity.Property(e => e.HlpaperMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLPaperMaterial");
            entity.Property(e => e.HlspacerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLSpacerMaterial");
            entity.Property(e => e.HorTieMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpedanceType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImportedDate).HasColumnType("datetime");
            entity.Property(e => e.ImportedSpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IndoorOutDoor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsulationClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.JackingPadQty).HasColumnName("JackingPadQTY");
            entity.Property(e => e.JackingPadType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kvalock).HasColumnName("KVALock");
            entity.Property(e => e.LeadSupportQty).HasColumnName("LeadSupportQTY");
            entity.Property(e => e.LeadSupportType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LiftLugBgauge).HasColumnName("LiftLugBGauge");
            entity.Property(e => e.LiftLugBqty).HasColumnName("LiftLugBQTY");
            entity.Property(e => e.LiftLugBtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LiftLugBType");
            entity.Property(e => e.LiftLugType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimbClamps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimitSwitchQty).HasColumnName("LimitSwitchQTY");
            entity.Property(e => e.LimitSwitchType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lvbil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("LVBil");
            entity.Property(e => e.Lveddies).HasColumnName("LVEddies");
            entity.Property(e => e.MainTankCorkMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshalBoxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshalBoxPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarshallBoxBracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModDate).HasColumnType("datetime");
            entity.Property(e => e.MountHolePositions)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mvbil)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("MVBil");
            entity.Property(e => e.Nermqty).HasColumnName("NERMQTY");
            entity.Property(e => e.Nermtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NERMType");
            entity.Property(e => e.Nerqty).HasColumnName("NERQTY");
            entity.Property(e => e.Nertype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NERType");
            entity.Property(e => e.Odpreset).HasColumnName("ODPreset");
            entity.Property(e => e.OilGuageMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilGuagePos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilThermMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilThermPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OilType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackingListPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PackingListPDF");
            entity.Property(e => e.ParentRef)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pdes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PDES");
            entity.Property(e => e.PhaseBarrierMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pmbenable).HasColumnName("PMBEnable");
            entity.Property(e => e.PoleMountBracketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriCboxEnable).HasColumnName("PriCBoxEnable");
            entity.Property(e => e.PriCboxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PriCBoxMaterial");
            entity.Property(e => e.PriOpenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriPocketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab1Qty).HasColumnName("PriSideLab1QTY");
            entity.Property(e => e.PriSideLab2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab2Qty).HasColumnName("PriSideLab2QTY");
            entity.Property(e => e.PriSideLab3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab3Qty).HasColumnName("PriSideLab3QTY");
            entity.Property(e => e.PriSideLab4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab4Qty).HasColumnName("PriSideLab4QTY");
            entity.Property(e => e.PriSideLab5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab5Qty).HasColumnName("PriSideLab5QTY");
            entity.Property(e => e.PriSideLab6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSideLab6Qty).HasColumnName("PriSideLab6QTY");
            entity.Property(e => e.ProductSpecPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProductSpecPDF");
            entity.Property(e => e.Prvdia).HasColumnName("PRVDIA");
            entity.Property(e => e.Prvenable).HasColumnName("PRVEnable");
            entity.Property(e => e.Prvmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVMaterial");
            entity.Property(e => e.Prvmplate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVMPLATE");
            entity.Property(e => e.Prvposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRVPosition");
            entity.Property(e => e.Prvx).HasColumnName("PRVX");
            entity.Property(e => e.Prvy).HasColumnName("PRVY");
            entity.Property(e => e.RadAssyPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RadAssyPDF");
            entity.Property(e => e.RangeId).HasColumnName("RangeID");
            entity.Property(e => e.RangeItemId).HasColumnName("RangeItemID");
            entity.Property(e => e.RatingPlateBracket)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseListPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ReleaseListPDF");
            entity.Property(e => e.Rpdepth).HasColumnName("RPDepth");
            entity.Property(e => e.Rpheight).HasColumnName("RPHeight");
            entity.Property(e => e.RplateMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RPlateMaterial");
            entity.Property(e => e.RplatePos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RPlatePos");
            entity.Property(e => e.Rpwidth).HasColumnName("RPWidth");
            entity.Property(e => e.Rpx).HasColumnName("RPX");
            entity.Property(e => e.Rpy).HasColumnName("RPY");
            entity.Property(e => e.Sales).HasColumnType("money");
            entity.Property(e => e.SaveVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecBushingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecCboxEnable).HasColumnName("SecCBoxEnable");
            entity.Property(e => e.SecCboxMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SecCBoxMaterial");
            entity.Property(e => e.SecOpenMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecPocketMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab1Qty).HasColumnName("SecSideLab1QTY");
            entity.Property(e => e.SecSideLab2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab2Qty).HasColumnName("SecSideLab2QTY");
            entity.Property(e => e.SecSideLab3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab3Qty).HasColumnName("SecSideLab3QTY");
            entity.Property(e => e.SecSideLab4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab4Qty).HasColumnName("SecSideLab4QTY");
            entity.Property(e => e.SecSideLab5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab5Qty).HasColumnName("SecSideLab5QTY");
            entity.Property(e => e.SecSideLab6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SecSideLab6Qty).HasColumnName("SecSideLab6QTY");
            entity.Property(e => e.SpecBase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecColour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecDesc)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.SpecInput)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecOutput)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecProjectDesc)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.SpecSpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecTaps)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecVector)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Standard)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StandardCclamp).HasColumnName("StandardCClamp");
            entity.Property(e => e.StiffenerMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankAssyPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TankAssyPDF");
            entity.Property(e => e.TankLabelsPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TankLabelsPDF");
            entity.Property(e => e.TankRimMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankrimType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TapeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TbdrawingPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBDrawingPDF");
            entity.Property(e => e.TblabelPdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBLabelPDF");
            entity.Property(e => e.TboardDepth).HasColumnName("TBoardDepth");
            entity.Property(e => e.TboardMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardMaterial");
            entity.Property(e => e.TboardPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TBoardPos");
            entity.Property(e => e.TboardThickness).HasColumnName("TBoardThickness");
            entity.Property(e => e.TboardWidth).HasColumnName("TBoardWidth");
            entity.Property(e => e.Term1Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term2Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term3Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Term4Material)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Testdatapdf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TESTDATAPDF");
            entity.Property(e => e.ThermPocketPos)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ThermPocketType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TmpBreatherEnable).HasColumnName("tmpBreatherEnable");
            entity.Property(e => e.TmpBucholtzEnable).HasColumnName("tmpBucholtzEnable");
            entity.Property(e => e.TmpDrainEnable).HasColumnName("tmpDrainEnable");
            entity.Property(e => e.TmpFillerEnable).HasColumnName("tmpFillerEnable");
            entity.Property(e => e.TmpOilGuageEnable).HasColumnName("tmpOilGuageEnable");
            entity.Property(e => e.TmpOilThermEnable).HasColumnName("tmpOilThermEnable");
            entity.Property(e => e.TmpPriCboxEnable).HasColumnName("tmpPriCBoxEnable");
            entity.Property(e => e.TmpPriPocketEnable).HasColumnName("tmpPriPocketEnable");
            entity.Property(e => e.TmpSecCboxEnable).HasColumnName("tmpSecCBoxEnable");
            entity.Property(e => e.TmpSecPocketEnable).HasColumnName("tmpSecPocketEnable");
            entity.Property(e => e.TmpTankSkidsEnable).HasColumnName("tmpTankSkidsEnable");
            entity.Property(e => e.TmpTapSwitchEnable).HasColumnName("tmpTapSwitchEnable");
            entity.Property(e => e.TotalVa).HasColumnName("TotalVA");
            entity.Property(e => e.TswitchBossDia).HasColumnName("TSwitchBossDia");
            entity.Property(e => e.TswitchBossMaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSwitchBossMaterial");
            entity.Property(e => e.TswitchBossPos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSwitchBossPos");
            entity.Property(e => e.TswitchBossX).HasColumnName("TSwitchBossX");
            entity.Property(e => e.TswitchBossY).HasColumnName("TSwitchBossY");
            entity.Property(e => e.TswitchHolY).HasColumnName("TSwitchHolY");
            entity.Property(e => e.TswitchHoleCentre).HasColumnName("TSwitchHoleCentre");
            entity.Property(e => e.TswitchHoleDia).HasColumnName("TSwitchHoleDia");
            entity.Property(e => e.TswitchHoleX).HasColumnName("TSwitchHoleX");
            entity.Property(e => e.Varange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VARange");
            entity.Property(e => e.VerTieRodMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VerTieStyle)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WedgeMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WheelsId).HasColumnName("WheelsID");
            entity.Property(e => e.WheelsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WheelsOd).HasColumnName("WheelsOD");
            entity.Property(e => e.WheelsQty).HasColumnName("WheelsQTY");
            entity.Property(e => e.WindingMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WindingSpecNotes)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WperKg).HasColumnName("WperKG");
            entity.Property(e => e.Wtienable).HasColumnName("WTIEnable");
        });

        modelBuilder.Entity<TempTanks>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_TANKS");

            entity.Property(e => e.CboxCount).HasColumnName("CBoxCount");
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RibPosName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SelectedTankBase)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TankBaseType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TankCboxThick).HasColumnName("TankCBoxThick");
            entity.Property(e => e.TankRimMaterial)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TankSlotsType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TankTypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tfbottom).HasColumnName("TFBottom");
            entity.Property(e => e.Tfguage).HasColumnName("TFGuage");
            entity.Property(e => e.Tfheight).HasColumnName("TFHeight");
            entity.Property(e => e.Tfholes).HasColumnName("TFHoles");
            entity.Property(e => e.TfslotHeight).HasColumnName("TFSlotHeight");
            entity.Property(e => e.TfslotWidth).HasColumnName("TFSlotWidth");
            entity.Property(e => e.Tftop).HasColumnName("TFTop");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.VentBoxType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempTaps>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_TAPS");

            entity.Property(e => e.Clength).HasColumnName("CLength");
            entity.Property(e => e.ConCsa).HasColumnName("ConCSA");
            entity.Property(e => e.DuctsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EdgeStripsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InterLayerInsMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadColour)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Leads)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LugsBmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LugsBMaterial");
            entity.Property(e => e.LugsBqty).HasColumnName("LugsBQty");
            entity.Property(e => e.LugsTmaterial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LugsTMaterial");
            entity.Property(e => e.LugsTqty).HasColumnName("LugsTQty");
            entity.Property(e => e.PriSec)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Txposition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TXPosition");
            entity.Property(e => e.Va).HasColumnName("VA");
            entity.Property(e => e.WireCost).HasColumnType("money");
            entity.Property(e => e.WireCovering)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TempWindings>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_WINDINGS");

            entity.Property(e => e.InsClass)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Va).HasColumnName("VA");
        });

        modelBuilder.Entity<TempWire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TEMP_WIRE");

            entity.Property(e => e.PriSec)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SpecNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WireIdno).HasColumnName("WireIDNo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
