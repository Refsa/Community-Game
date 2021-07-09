// Copyright 2021 Boppy Games, LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudioEvent : MonoBehaviour
{
  public enum AudioEvent
  {
    ButtonPress,
  }
  
  [SerializeField] AudioEvent audioEvent;
  
  // Invoked by Button component when pressed.
  public void Pressed()
  {
    UIAudioSingleton.Instance.OnEvent(audioEvent);
  }
}