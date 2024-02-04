public class Fighter
{
  public string name;
  public int hp = 100;
  public int weaponDamage = 10;

  public void Attack( Fighter target)
  {
    target.hp -= Random.Shared.Next(weaponDamage);
  }

  public void IsDead()
  {
    if (hp <= 0)
    {
      Console.WriteLine($"{name} is dead!");
    }
  }
}