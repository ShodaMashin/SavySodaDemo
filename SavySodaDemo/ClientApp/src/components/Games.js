import React, { Component } from 'react';
import Moment from 'react-moment';

export class Games extends Component {
  static displayName = Games.name;

  constructor(props) {
    super(props);
    this.state = { games: [], loading: true };
  }

  componentDidMount() {
    this.populateGameData();
  }

  static renderGamesList(games) {
      return (
          <div className='row'>
              {games.map(game =>
                  <div className='game-box container' key={game.id}>
                      <div className='row'>
                          <div className='col game-header text-center'>
                              {game.title}
                          </div>
                      </div>
                      <div className='row'>
                          <div className='col game-header text-center'>
                              <Moment format="DD/MM/YYYY">
                                  {game.releaseDate}
                              </Moment>
                          </div>
                          <div className='col game-header text-center'>
                              {game.genre}
                          </div>
                      </div>
                      <div className='row'>
                          <div className='col game-img text-center'>
                              <img height='300px' src={game.imageUrl}/>
                          </div>
                          <div className='col game-desc'>
                              {game.description}
                          </div>
                      </div>
                  </div>
              )}
          </div>
      );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Games.renderGamesList(this.state.games);

    return (
      <div>
        <h1 id="tabelLabel" >Games</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateGameData() {
    const response = await fetch('game');
    const data = await response.json();
    this.setState({ games: data, loading: false });
  }
}
