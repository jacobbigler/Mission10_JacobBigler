import logo from './splithappens.png';

function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="Logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <h4 className="text-white">This ain't the bush league</h4>
        <br />
        <p className="text-white">
          Here are the players involved in the final:
        </p>
        <h3 className="text-white">MARLINS vs. SHARKS</h3>
      </div>
    </header>
  );
}

export default Header;
