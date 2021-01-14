﻿using System;
using System.Collections.Generic;
using System.Text;
using Examples.Charge.Application.Common.Messages;
using Examples.Charge.Application.Dtos;

namespace Examples.Charge.Application.Messages.Response
{
	public class PersonObjectResponse : BaseResponse
	{
		public PersonDto PersonObject { get; set; }
	}
}
