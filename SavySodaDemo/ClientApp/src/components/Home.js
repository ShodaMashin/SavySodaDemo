import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>C# .NET Core and Entity Framework Test Project</h1>
        <p>This is a single-page application, built with:</p>
        <ul>
          <li><a href='https://get.asp.net/'>ASP.NET Core</a> and <a href='https://msdn.microsoft.com/en-us/library/67ef8sbd.aspx'>C#</a> for cross-platform server-side code</li>
          <li><a href='https://facebook.github.io/react/'>React</a> for client-side code</li>
          <li><a href='http://getbootstrap.com/'>Bootstrap</a> for layout and styling</li>
                <li><a href='https://docs.microsoft.com/en-us/ef/'>Microsoft Entity Framework</a> for Database connections</li>
        </ul>
            <p>To view the demo, navigate to the Games tab in the top right corner.</p>
      </div>
    );
  }
}
