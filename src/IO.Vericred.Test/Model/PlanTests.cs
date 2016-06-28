/* 
 * Vericred API
 *
 * Vericred's API allows you to search for Health Plans that a specific doctor
accepts.

## Getting Started

Visit our [Developer Portal](https://vericred.3scale.net) to
create an account.

Once you have created an account, you can create one Application for
Production and another for our Sandbox (select the appropriate Plan when
you create the Application).

## Authentication

To authenticate, pass the API Key you created in the Developer Portal as
a `Vericred-Api-Key` header.

`curl -H 'Vericred-Api-Key: YOUR_KEY' "https://api.vericred.com/providers?search_term=Foo&zip_code=11215"`

## Versioning

Vericred's API default to the latest version.  However, if you need a specific
version, you can request it with an `Accept-Version` header.

The current version is `v3`.  Previous versions are `v1` and `v2`.

`curl -H 'Vericred-Api-Key: YOUR_KEY' -H 'Accept-Version: v2' "https://api.vericred.com/providers?search_term=Foo&zip_code=11215"`

## Pagination

Endpoints that accept `page` and `per_page` parameters are paginated. They expose
four additional fields that contain data about your position in the response,
namely `Total`, `Per-Page`, `Link`, and `Page` as described in [RFC-5988](https://tools.ietf.org/html/rfc5988).

For example, to display 5 results per page and view the second page of a
`GET` to `/networks`, your final request would be `GET /networks?....page=2&per_page=5`.

## Sideloading

When we return multiple levels of an object graph (e.g. `Provider`s and their `State`s
we sideload the associated data.  In this example, we would provide an Array of
`State`s and a `state_id` for each provider.  This is done primarily to reduce the
payload size since many of the `Provider`s will share a `State`

```
{
  providers: [{ id: 1, state_id: 1}, { id: 2, state_id: 1 }],
  states: [{ id: 1, code: 'NY' }]
}
```

If you need the second level of the object graph, you can just match the
corresponding id.

## Selecting specific data

All endpoints allow you to specify which fields you would like to return.
This allows you to limit the response to contain only the data you need.

For example, let's take a request that returns the following JSON by default

```
{
  provider: {
    id: 1,
    name: 'John',
    phone: '1234567890',
    field_we_dont_care_about: 'value_we_dont_care_about'
  },
  states: [{
    id: 1,
    name: 'New York',
    code: 'NY',
    field_we_dont_care_about: 'value_we_dont_care_about'
  }]
}
```

To limit our results to only return the fields we care about, we specify the
`select` query string parameter for the corresponding fields in the JSON
document.

In this case, we want to select `name` and `phone` from the `provider` key,
so we would add the parameters `select=provider.name,provider.phone`.
We also want the `name` and `code` from the `states` key, so we would
add the parameters `select=states.name,staes.code`.  The id field of
each document is always returned whether or not it is requested.

Our final request would be `GET /providers/12345?select=provider.name,provider.phone,states.name,states.code`

The response would be

```
{
  provider: {
    id: 1,
    name: 'John',
    phone: '1234567890'
  },
  states: [{
    id: 1,
    name: 'New York',
    code: 'NY'
  }]
}
```


 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Vericred.Api;
using IO.Vericred.Model;
using IO.Vericred.Client;
using System.Reflection;

namespace IO.Vericred.Test
{
    /// <summary>
    ///  Class for testing Plan
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PlanTests
    {
        // TODO uncomment below to declare an instance variable for Plan
        //private Plan instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Plan
            //instance = new Plan();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Plan
        /// </summary>
        [Test]
        public void PlanInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Plan
            //Assert.IsInstanceOfType<Plan> (instance, "variable 'instance' is a Plan");
        }

        /// <summary>
        /// Test the property 'AdultDental'
        /// </summary>
        [Test]
        public void AdultDentalTest()
        {
            // TODO unit test for the property 'AdultDental'
        }
        /// <summary>
        /// Test the property 'Age29Rider'
        /// </summary>
        [Test]
        public void Age29RiderTest()
        {
            // TODO unit test for the property 'Age29Rider'
        }
        /// <summary>
        /// Test the property 'Ambulance'
        /// </summary>
        [Test]
        public void AmbulanceTest()
        {
            // TODO unit test for the property 'Ambulance'
        }
        /// <summary>
        /// Test the property 'BenefitsSummaryUrl'
        /// </summary>
        [Test]
        public void BenefitsSummaryUrlTest()
        {
            // TODO unit test for the property 'BenefitsSummaryUrl'
        }
        /// <summary>
        /// Test the property 'BuyLink'
        /// </summary>
        [Test]
        public void BuyLinkTest()
        {
            // TODO unit test for the property 'BuyLink'
        }
        /// <summary>
        /// Test the property 'CarrierName'
        /// </summary>
        [Test]
        public void CarrierNameTest()
        {
            // TODO unit test for the property 'CarrierName'
        }
        /// <summary>
        /// Test the property 'ChildDental'
        /// </summary>
        [Test]
        public void ChildDentalTest()
        {
            // TODO unit test for the property 'ChildDental'
        }
        /// <summary>
        /// Test the property 'ChildEyewear'
        /// </summary>
        [Test]
        public void ChildEyewearTest()
        {
            // TODO unit test for the property 'ChildEyewear'
        }
        /// <summary>
        /// Test the property 'ChildEyeExam'
        /// </summary>
        [Test]
        public void ChildEyeExamTest()
        {
            // TODO unit test for the property 'ChildEyeExam'
        }
        /// <summary>
        /// Test the property 'CustomerServicePhoneNumber'
        /// </summary>
        [Test]
        public void CustomerServicePhoneNumberTest()
        {
            // TODO unit test for the property 'CustomerServicePhoneNumber'
        }
        /// <summary>
        /// Test the property 'DurableMedicalEquipment'
        /// </summary>
        [Test]
        public void DurableMedicalEquipmentTest()
        {
            // TODO unit test for the property 'DurableMedicalEquipment'
        }
        /// <summary>
        /// Test the property 'DiagnosticTest'
        /// </summary>
        [Test]
        public void DiagnosticTestTest()
        {
            // TODO unit test for the property 'DiagnosticTest'
        }
        /// <summary>
        /// Test the property 'DpRider'
        /// </summary>
        [Test]
        public void DpRiderTest()
        {
            // TODO unit test for the property 'DpRider'
        }
        /// <summary>
        /// Test the property 'DrugFormularyUrl'
        /// </summary>
        [Test]
        public void DrugFormularyUrlTest()
        {
            // TODO unit test for the property 'DrugFormularyUrl'
        }
        /// <summary>
        /// Test the property 'EffectiveDate'
        /// </summary>
        [Test]
        public void EffectiveDateTest()
        {
            // TODO unit test for the property 'EffectiveDate'
        }
        /// <summary>
        /// Test the property 'ExpirationDate'
        /// </summary>
        [Test]
        public void ExpirationDateTest()
        {
            // TODO unit test for the property 'ExpirationDate'
        }
        /// <summary>
        /// Test the property 'EmergencyRoom'
        /// </summary>
        [Test]
        public void EmergencyRoomTest()
        {
            // TODO unit test for the property 'EmergencyRoom'
        }
        /// <summary>
        /// Test the property 'FamilyDrugDeductible'
        /// </summary>
        [Test]
        public void FamilyDrugDeductibleTest()
        {
            // TODO unit test for the property 'FamilyDrugDeductible'
        }
        /// <summary>
        /// Test the property 'FamilyDrugMoop'
        /// </summary>
        [Test]
        public void FamilyDrugMoopTest()
        {
            // TODO unit test for the property 'FamilyDrugMoop'
        }
        /// <summary>
        /// Test the property 'FamilyMedicalDeductible'
        /// </summary>
        [Test]
        public void FamilyMedicalDeductibleTest()
        {
            // TODO unit test for the property 'FamilyMedicalDeductible'
        }
        /// <summary>
        /// Test the property 'FamilyMedicalMoop'
        /// </summary>
        [Test]
        public void FamilyMedicalMoopTest()
        {
            // TODO unit test for the property 'FamilyMedicalMoop'
        }
        /// <summary>
        /// Test the property 'FpRider'
        /// </summary>
        [Test]
        public void FpRiderTest()
        {
            // TODO unit test for the property 'FpRider'
        }
        /// <summary>
        /// Test the property 'GenericDrugs'
        /// </summary>
        [Test]
        public void GenericDrugsTest()
        {
            // TODO unit test for the property 'GenericDrugs'
        }
        /// <summary>
        /// Test the property 'HabilitationServices'
        /// </summary>
        [Test]
        public void HabilitationServicesTest()
        {
            // TODO unit test for the property 'HabilitationServices'
        }
        /// <summary>
        /// Test the property 'HiosIssuerId'
        /// </summary>
        [Test]
        public void HiosIssuerIdTest()
        {
            // TODO unit test for the property 'HiosIssuerId'
        }
        /// <summary>
        /// Test the property 'HomeHealthCare'
        /// </summary>
        [Test]
        public void HomeHealthCareTest()
        {
            // TODO unit test for the property 'HomeHealthCare'
        }
        /// <summary>
        /// Test the property 'HospiceService'
        /// </summary>
        [Test]
        public void HospiceServiceTest()
        {
            // TODO unit test for the property 'HospiceService'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Imaging'
        /// </summary>
        [Test]
        public void ImagingTest()
        {
            // TODO unit test for the property 'Imaging'
        }
        /// <summary>
        /// Test the property 'InNetworkIds'
        /// </summary>
        [Test]
        public void InNetworkIdsTest()
        {
            // TODO unit test for the property 'InNetworkIds'
        }
        /// <summary>
        /// Test the property 'IndividualDrugDeductible'
        /// </summary>
        [Test]
        public void IndividualDrugDeductibleTest()
        {
            // TODO unit test for the property 'IndividualDrugDeductible'
        }
        /// <summary>
        /// Test the property 'IndividualDrugMoop'
        /// </summary>
        [Test]
        public void IndividualDrugMoopTest()
        {
            // TODO unit test for the property 'IndividualDrugMoop'
        }
        /// <summary>
        /// Test the property 'IndividualMedicalDeductible'
        /// </summary>
        [Test]
        public void IndividualMedicalDeductibleTest()
        {
            // TODO unit test for the property 'IndividualMedicalDeductible'
        }
        /// <summary>
        /// Test the property 'IndividualMedicalMoop'
        /// </summary>
        [Test]
        public void IndividualMedicalMoopTest()
        {
            // TODO unit test for the property 'IndividualMedicalMoop'
        }
        /// <summary>
        /// Test the property 'InpatientBirth'
        /// </summary>
        [Test]
        public void InpatientBirthTest()
        {
            // TODO unit test for the property 'InpatientBirth'
        }
        /// <summary>
        /// Test the property 'InpatientFacility'
        /// </summary>
        [Test]
        public void InpatientFacilityTest()
        {
            // TODO unit test for the property 'InpatientFacility'
        }
        /// <summary>
        /// Test the property 'InpatientMentalHealth'
        /// </summary>
        [Test]
        public void InpatientMentalHealthTest()
        {
            // TODO unit test for the property 'InpatientMentalHealth'
        }
        /// <summary>
        /// Test the property 'InpatientPhysician'
        /// </summary>
        [Test]
        public void InpatientPhysicianTest()
        {
            // TODO unit test for the property 'InpatientPhysician'
        }
        /// <summary>
        /// Test the property 'InpatientSubstance'
        /// </summary>
        [Test]
        public void InpatientSubstanceTest()
        {
            // TODO unit test for the property 'InpatientSubstance'
        }
        /// <summary>
        /// Test the property 'Level'
        /// </summary>
        [Test]
        public void LevelTest()
        {
            // TODO unit test for the property 'Level'
        }
        /// <summary>
        /// Test the property 'LogoUrl'
        /// </summary>
        [Test]
        public void LogoUrlTest()
        {
            // TODO unit test for the property 'LogoUrl'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'NetworkSize'
        /// </summary>
        [Test]
        public void NetworkSizeTest()
        {
            // TODO unit test for the property 'NetworkSize'
        }
        /// <summary>
        /// Test the property 'NonPreferredBrandDrugs'
        /// </summary>
        [Test]
        public void NonPreferredBrandDrugsTest()
        {
            // TODO unit test for the property 'NonPreferredBrandDrugs'
        }
        /// <summary>
        /// Test the property 'OnMarket'
        /// </summary>
        [Test]
        public void OnMarketTest()
        {
            // TODO unit test for the property 'OnMarket'
        }
        /// <summary>
        /// Test the property 'OffMarket'
        /// </summary>
        [Test]
        public void OffMarketTest()
        {
            // TODO unit test for the property 'OffMarket'
        }
        /// <summary>
        /// Test the property 'OutOfNetworkCoverage'
        /// </summary>
        [Test]
        public void OutOfNetworkCoverageTest()
        {
            // TODO unit test for the property 'OutOfNetworkCoverage'
        }
        /// <summary>
        /// Test the property 'OutOfNetworkIds'
        /// </summary>
        [Test]
        public void OutOfNetworkIdsTest()
        {
            // TODO unit test for the property 'OutOfNetworkIds'
        }
        /// <summary>
        /// Test the property 'OutpatientFacility'
        /// </summary>
        [Test]
        public void OutpatientFacilityTest()
        {
            // TODO unit test for the property 'OutpatientFacility'
        }
        /// <summary>
        /// Test the property 'OutpatientMentalHealth'
        /// </summary>
        [Test]
        public void OutpatientMentalHealthTest()
        {
            // TODO unit test for the property 'OutpatientMentalHealth'
        }
        /// <summary>
        /// Test the property 'OutpatientPhysician'
        /// </summary>
        [Test]
        public void OutpatientPhysicianTest()
        {
            // TODO unit test for the property 'OutpatientPhysician'
        }
        /// <summary>
        /// Test the property 'OutpatientSubstance'
        /// </summary>
        [Test]
        public void OutpatientSubstanceTest()
        {
            // TODO unit test for the property 'OutpatientSubstance'
        }
        /// <summary>
        /// Test the property 'PlanMarket'
        /// </summary>
        [Test]
        public void PlanMarketTest()
        {
            // TODO unit test for the property 'PlanMarket'
        }
        /// <summary>
        /// Test the property 'PlanType'
        /// </summary>
        [Test]
        public void PlanTypeTest()
        {
            // TODO unit test for the property 'PlanType'
        }
        /// <summary>
        /// Test the property 'PreferredBrandDrugs'
        /// </summary>
        [Test]
        public void PreferredBrandDrugsTest()
        {
            // TODO unit test for the property 'PreferredBrandDrugs'
        }
        /// <summary>
        /// Test the property 'PrenatalPostnatalCare'
        /// </summary>
        [Test]
        public void PrenatalPostnatalCareTest()
        {
            // TODO unit test for the property 'PrenatalPostnatalCare'
        }
        /// <summary>
        /// Test the property 'PreventativeCare'
        /// </summary>
        [Test]
        public void PreventativeCareTest()
        {
            // TODO unit test for the property 'PreventativeCare'
        }
        /// <summary>
        /// Test the property 'PremiumSubsidized'
        /// </summary>
        [Test]
        public void PremiumSubsidizedTest()
        {
            // TODO unit test for the property 'PremiumSubsidized'
        }
        /// <summary>
        /// Test the property 'Premium'
        /// </summary>
        [Test]
        public void PremiumTest()
        {
            // TODO unit test for the property 'Premium'
        }
        /// <summary>
        /// Test the property 'PrimaryCarePhysician'
        /// </summary>
        [Test]
        public void PrimaryCarePhysicianTest()
        {
            // TODO unit test for the property 'PrimaryCarePhysician'
        }
        /// <summary>
        /// Test the property 'RehabilitationServices'
        /// </summary>
        [Test]
        public void RehabilitationServicesTest()
        {
            // TODO unit test for the property 'RehabilitationServices'
        }
        /// <summary>
        /// Test the property 'SkilledNursing'
        /// </summary>
        [Test]
        public void SkilledNursingTest()
        {
            // TODO unit test for the property 'SkilledNursing'
        }
        /// <summary>
        /// Test the property 'Specialist'
        /// </summary>
        [Test]
        public void SpecialistTest()
        {
            // TODO unit test for the property 'Specialist'
        }
        /// <summary>
        /// Test the property 'SpecialtyDrugs'
        /// </summary>
        [Test]
        public void SpecialtyDrugsTest()
        {
            // TODO unit test for the property 'SpecialtyDrugs'
        }
        /// <summary>
        /// Test the property 'UrgentCare'
        /// </summary>
        [Test]
        public void UrgentCareTest()
        {
            // TODO unit test for the property 'UrgentCare'
        }

    }

}
