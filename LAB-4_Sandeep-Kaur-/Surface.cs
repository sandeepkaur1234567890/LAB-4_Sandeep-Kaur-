using LAB_4_Sandeep_Kaur_.Geometry2D;
using LAB_4_Sandeep_Kaur_.Particles;

namespace LAB_4_Sandeep_Kaur_.ModelComponents
{
	public interface ISurface
	{
		Cell HandlePhonon(Phonon p);
	}

	public class BoundarySurface : ISurface
	{
		public SurfaceLocation Location { get; }
		protected Cell cell;

		public BoundarySurface(SurfaceLocation location, Cell cell)
		{
			Location = location;
			this.cell = cell;
		}
		public virtual Cell HandlePhonon(Phonon p)
		{
			Vector direction = p.Direction;
			if (Location == SurfaceLocation.left || Location == SurfaceLocation.right)
			{
				p.SetDirection(-direction.DX, direction.DY);
			}
			else
			{
				p.SetDirection(direction.DX, -direction.DY);
			}
			return cell;
		}
	}
}
