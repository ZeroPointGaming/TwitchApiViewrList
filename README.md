# TwitchApiViewerList

A Windows Forms application written in Visual Basic .NET that retrieves and displays the live viewer list of a Twitch channel using Twitch’s public chatters API.

This project demonstrates real time API polling, JSON deserialization, structured data grouping, and persistent user configuration within a desktop application environment.

---

## Overview

TwitchApiViewerList allows streamers or moderators to monitor who is currently connected to a Twitch channel’s chat in real time. The application periodically queries Twitch’s public chatters endpoint and categorizes connected users by role, presenting the data in a clean and organized interface.

The target channel username is stored in application settings and can be updated at any time through a dedicated settings form.

---

## Features

- Real time retrieval of Twitch chat participant data
- Automatic refresh of viewer lists at regular intervals
- Manual refresh option
- Persistent storage of the selected Twitch channel username
- Categorized display of chat participants by role
- Simple WinForms based user interface
- Graceful error handling for missing or invalid configuration

---

## User Categories Displayed

The application organizes chat participants into separate lists based on Twitch assigned roles:

- Broadcaster
- Moderators
- VIPs
- Viewers
- Twitch Staff
- Administrators
- Global Moderators

This grouping allows quick visibility into channel moderation presence and audience engagement.

---

## API Used

- **Twitch Chatters API**  
  `https://tmi.twitch.tv/group/user/{channel}/chatters`

This endpoint provides a real time snapshot of users currently connected to a channel’s chat without requiring OAuth authentication.

---

## Technologies

- Visual Basic .NET
- Windows Forms
- HTTP Web Requests
- JSON Serialization and Deserialization
- Application Settings Persistence
- Timer based background refresh

---

## Configuration

1. Launch the application.
2. Open the settings window.
3. Enter the Twitch channel username (the portion after `twitch.tv/`).
4. Save the settings.

The application will automatically begin retrieving and refreshing the viewer list for the configured channel.

---

## Refresh Behavior

- Viewer data is refreshed automatically at a fixed interval using a timer.
- A manual refresh button is also available for on demand updates.

---

## Notes

- The Twitch Chatters API is publicly accessible and does not require authentication.
- Viewer counts and lists reflect users currently connected to chat, not necessarily active chat participants.
- API availability and response structure are subject to Twitch platform changes.

---

## License

This project is provided for educational and demonstration purposes.  
Use of Twitch services is subject to Twitch’s terms of service.

---

## Author

Developed as part of a professional software engineering portfolio to demonstrate API driven desktop application development, structured JSON processing, and real time data visualization in Visual Basic .NET.
