import NavlinkStruct from "../../components/NavlinkStruct/NavlinkStruct"
import { useState, useEffect } from "react"
import "../../App.css"
import "./Terms.css"
import { Link } from "react-router-dom"
import useWindowWidth from "../../hooks/useWindowWidth"

const leftMenu = [
  { id: "terms", title: "Terms & Conditions", subTitle: "Eligibility Requirements for Promotions" },
  { id: "offering", title: "Privacy Policy", subTitle: "" },
  { id: "subscription", title: "Terms Of Service", subTitle: "" }
];

function Terms() {
  const [activeMenu, setActiveMenu] = useState("terms");
  const [openDoc, setOpenDoc] = useState(null);

  // здесь храним документы по категориям
  const [documents, setDocuments] = useState({
    terms: [],
    offering: [],
    subscription: []
  });

  // ---- USE EFFECT: наполняем массивы ----
  useEffect(() => {
    const loadDocs = () => {
      const generatedDocs = {
        terms: [
          {
            title: "August 2025 4% Bonus Promo Terms and Conditions",
            content: "This Limited Time Offer is applicable to GFL Holdings investors who transfer total funds equal to or exceeding the Qualifying Amount and invest those funds into the GFL Holdings Investment Portfolio during the Promotional Period.\n\nAll transfers, commitments, and investments must be made in a Qualifying Amount in a single, new Qualifying Account by an individual or business entity that does not already have a GFL Holdings Account. Amounts transferred, committed, or invested cannot be aggregated to reach a Qualifying Amount across multiple Qualifying Accounts. The definition of a Qualifying Account is subject to change at the sole discretion of GFL Holdings. Investments must be made into qualifying products offered within the GFL Holdings platform, including the GFL Holdings Investment Portfolio. Retirement-type accounts or equivalent structures are not Qualifying Accounts and are ineligible for this promotion.\n\nThe Promotional Period shall begin on August 1, 2025 and end on August 12, 2025 at 11:59 PM Eastern Time. The “Promotional Period” denotes the duration within which the Qualifying Amount must be invested into the Qualifying Account. The “Qualification Period” refers to the duration during which the promotional Qualifying Amount must remain invested in the Qualifying Account to be eligible for the Investment Bonus. The Qualifying Amount shall be at least $10,000, with the 4% bonus credit being eligible for every $10,000 invested. Any transfers out during the Qualification Period and investment cancellations during the Qualification Period shall be netted against otherwise qualifying transfers, commitments, and investments in calculating eligibility.\n\nAny tabulation, report, or indication of Qualifying Amounts and bonuses earned under this promotion that is provided to you via our website, automated email, management personnel, or customer service representatives is not conclusive and is subject to revision or correction at any time in the exclusive discretion of GFL Holdings.\n\nAn Investment Bonus of 4% (four percent) shall be credited to the Qualifying Account in the form of restricted credits for the Qualifying Amount meeting all of the Eligibility Requirements. The Investment Bonus will be added to your GFL Holdings account no later than September 30, 2025. Restricted credits earned can be used toward the purchase of any Qualifying Investment. The restricted credits cannot be withdrawn as cash. If the restricted credit is not used within one year of issuance, it will expire and be removed from your GFL Holdings account.\n\nParticipation in this program may require the issuance of documentation or disclosures in accordance with applicable regulations. Users are responsible for any obligations, including reporting requirements, related to participating in the promotion. This Limited Time Offer is subject to change and may be canceled at any time without notice. In cases where we have a reasonable belief of fraud, we reserve the right to rescind any restricted credits that may have been given, at any time. This Limited Time Offer cannot be combined with any other GFL Holdings promotion."
          },
          {
            title: "Portfolio Promotion Terms and Conditions",
            content: "This Limited Time Offer is applicable to GFL Holdings investors who meet all of the following requirements: Invest into the GFL Holdings Investment Portfolio during the Promotional Period and the investment settles and is not canceled.\n\nAll investments must be made and confirmed during the timeframe of the Promotional Period. All investments must be made in a Qualifying Amount by an individual or business entity. Amounts invested cannot be aggregated to reach a Qualifying Amount across multiple Qualifying Accounts. The definition of a Qualifying Account is subject to change at the sole discretion of GFL Holdings. GFL Holdings maintains four investment account types, each of which may qualify for this promotion depending on the company’s discretion.\n\nAll promo credits that apply to a purchase of the GFL Holdings Investment Portfolio will be made into a Qualified Account. The Investment Period for each annual cycle shall begin on March 17 at 12:00 AM GMT and end on June 17 at 11:59 PM GMT. The Promotional Period shall begin on March 17 and end on June 17 at 11:59 PM GMT for each applicable year through December 31, 2027. The Qualification Period shall begin simultaneously with the Investment Period and shall end on June 17 at 11:59 PM GMT of the same year, unless extended at the sole option of GFL Holdings. The “Promotional Period” denotes the duration within which the Qualifying Amount must be invested into the Qualifying Account. The “Qualification Period” refers to the duration during which the promotional Qualifying Amount must remain invested in the Qualifying Account to be eligible for the Investment Bonus.\n\nThe Qualifying Amount shall be at least $10,000 and no more than $500,000 (five hundred thousand dollars), with the $200 bonus being eligible for every $10,000 invested. Any transfers out during the Qualification Period and investment cancellations during the Qualification Period shall be netted against otherwise qualifying transfers, commitments, and investments in calculating eligibility. Any tabulation, report, or indication of Qualifying Amounts and bonuses earned under this promotion that is provided to you via our website, automated email, management personnel, or customer service representatives is not conclusive and is subject to revision or correction at any time in the exclusive discretion of GFL Holdings. Any total investment amount above the maximum qualifying amount of $500,000 will not be eligible for this promotion.\n\nAn Investment Bonus of $200 for every $10,000 invested shall be credited to the Qualifying Account in the form of restricted credits for the Qualifying Amount meeting all the Eligibility Requirements up to a maximum of $10,000 (ten thousand dollars) in Investment Bonuses in aggregate per user across all Qualifying Accounts. Please note that earnings are calculated based on the specific investment amount. For every $10,000 invested, you may earn $200. However, returns do not scale linearly; partial investments may not yield proportional bonus credit. The Investment Bonus will be added to your GFL Holdings account no later than September 21 following the conclusion of each annual Promotional Period. Restricted credits earned can be used towards the purchase of any Qualifying Investment.\n\nThe restricted credits cannot be withdrawn as cash. If the restricted credit is not used within one year of issuance, it will expire and be removed from your GFL Holdings account. Participation in this program may require the issuance of documentation or reporting in accordance with applicable regulatory requirements. Users are responsible for any obligations, including disclosures, associated with participating in the promotion. Please consult a professional advisor if you have any questions about your personal compliance requirements. This Limited Time Offer is subject to change and may be canceled at any time without notice. In cases where we have a reasonable belief of fraud, we reserve the right to rescind any restricted credits that may have been given, at any time. This Limited Time Offer cannot be combined with any other GFL Holdings promotion.\n\nGFL Holdings is a United Kingdom–based company providing investment services across all CIS countries and European territories, excluding the United States, Israel, and China."
          }
        ],
        offering: [
          {
            title: "Privacy Policy",
            content: [
              "GFL Holdings values your privacy and the protection of your personal information. We collect and maintain certain categories of information from you in order to provide and improve our investment services within the European Union and the Commonwealth of Independent States. It is important to explain our policy and the terms and conditions governing the collection, processing, storage, and use of your information under applicable UK and EU regulations.",
              "GFL Holdings does not operate in, and does not provide services to, residents of the United States, Israel, or the People’s Republic of China."
            ]
          },
          {
            title: "Conduct of GFL Holdings Employees",
            content: [
              "GFL Holdings is committed to upholding the highest professional and ethical standards. Our corporate values are founded on integrity, and we expect our employees to act with your best interests in mind when handling your personal information. Our internal Code of Conduct contains specific guidelines regarding the safeguarding of confidential data, including investor information. These guidelines restrict employee access to confidential information and limit the use and disclosure of such information to authorized processes and transactions only.",
              "If it is determined that any employee has violated the Code of Conduct, disciplinary measures may be taken, including immediate termination of employment."
            ]
          },
          {
            title: "Review and Control of Privacy Practices",
            content: [
              "GFL Holdings periodically reviews its operations and internal practices to ensure compliance with corporate policies and legal requirements relating to confidentiality and data protection. These reviews may be conducted by internal departments, external auditing firms, or regulatory authorities. Included in these reviews are assessments of the administrative, physical, and technical safeguards designed to protect personal information."
            ]
          },
          {
            title: "Mobile Terms and Conditions",
            content: [
              "You agree to receive automated informational and optional promotional messages from GFL Holdings, including messages that may be sent using automated systems, to the mobile telephone number you provided during registration. Consent to receive such messages is not a condition of using our services. Message frequency may vary. Standard messaging and data rates may apply depending on your carrier.",
              "To opt out of marketing messages, reply STOP, END, CANCEL, UNSUBSCRIBE, or QUIT to our designated number. After opting out, you will receive one additional message confirming that your request has been processed. For assistance, reply HELP or contact us at support@gflholdings.uk.",
              "The information you provide, including your mobile number, will not be sold or disclosed to third parties for marketing or advertising purposes, and will be processed in accordance with GDPR and the UK Data Protection Act."
            ]
          },
          {
            title: "Introduction",
            content: [
              "The GFL Holdings Privacy Policy discloses what information we collect and how we use it. We also explain how any personal or personally identifiable information may be processed and safeguarded. Additionally, we outline our security measures designed to protect your information both digitally and physically.",
              "In general, and as detailed below, we collect several types of information from you:\n - Personal information required to verify your identity\n - Personal and financial information necessary to assess your eligibility to invest through GFL Holdings\n - Optional personal information you may choose to provide\n - Technical and usage information relating to your visits to our website or authorized service providers"
            ]
          },
          {
            title: "Customer Information That GFL Holdings Collects",
            content: [
              "GFL Holdings collects personal and financial information from you while you use our platform, particularly during registration. Some information is mandatory and some is optional.",
              "Certain information remains private, while other information may be displayed to other users. You will be informed which information is private and which is visible to users. Additional information may be collected throughout your use of the platform when you choose to provide it.\n\t(a) enabling registered users to access the platform\n\t(b) verifying investor identities,\n\t(c) assessing eligibility to participate in investment activities,\n\t(d) confirming that users meet minimum age and legal requirements, and\n\t(e) guarding against fraud.",
              "This information generally includes:\n - Your name\n - Your email address\n - Your date of birth\n - Your physical address and telephone number\n - Proof-of-identity information compliant with UK and EU regulations (non-US)"
            ]
          },
          {
            title: "Additional Information You Provide to GFL Holdings",
            content: [
              "Once registered, you may provide additional information on a voluntary basis. This includes, but is not limited to, investment experience, objectives, preferred asset types, communication preferences, and documents you upload to verify eligibility under UK and EU investment regulations. You may also participate in surveys, questionnaires, or provide feedback that GFL Holdings may use to improve its services. Providing this information is voluntary, and choosing not to provide it will not prevent you from using our platform, unless such information becomes required under applicable law."
            ]
          },
          {
            title: "Information From Your Activity on the Platform",
            content: [
              "During your use of the GFL Holdings platform, we automatically collect information about your interactions, including:",
              "Device information (browser type, operating system, device identifiers)",
              "Access times and referral URLs",
              "Page views, click activity, and transaction history",
              "IP address and geolocation as permitted by law",
              "Preferences and actions taken through your account",
              "This information helps us authenticate users, maintain platform security, optimize performance, and personalize your experience."
            ]
          },
          {
            title: "Information From Third Parties",
            content: [
              "To comply with UK and EU regulatory frameworks and Anti-Money Laundering (AML) and Know Your Customer (KYC) requirements, GFL Holdings may obtain information about you from authorized third-party services. This information may include identity verification data, sanctions screening results, or confirmation of corporate records for business entities. We do not obtain data from US credit bureaus or any US federal databases."
            ]
          },
          {
            title: "How GFL Holdings Uses This Information",
            content: [
              "GFL Holdings uses your information for several purposes, including:\n - Establishing and maintaining your account\n - Verifying your identity and eligibility under applicable regulations\n - Facilitating investments and portfolio management\n - Processing transactions and providing confirmations\n - Improving platform functionality and user experience\n - Complying with UK, EU, and local laws in the countries where we operate\n - Preventing fraud and ensuring platform integrity\n - We do not sell your personal information. We do not share your personal information with third parties for advertising purposes."
            ]
          },
          {
            title: "When GFL Holdings Shares Your Information",
            content: [
              "GFL Holdings may share your information with:\n - Regulatory authorities in the UK, EU, and relevant CIS jurisdictions\n - Licensed service providers performing identity verification, AML checks, payment processing, hosting, or data security\n - Legal representatives when required by law, court order, or regulatory investigation\n - Business partners involved in the operational delivery of our investment services\n - In all cases, third parties are contractually required to protect your information under GDPR and UK Data Protection Act standards.\nGFL Holdings does not share personal data with organizations located in the United States, Israel, China, or any jurisdiction outside the UK/EU without ensuring appropriate safeguards."
            ]
          },
          {
            title: "Storing Personal Information",
            content: [
              "Your information is stored securely in data centers located within the United Kingdom and the European Union. These facilities employ administrative, technical, and physical safeguards designed to comply with GDPR and UK data protection standards.",
              "Access to personal information is strictly limited to authorized personnel who require the information to perform their duties.",
              "We retain personal information only as long as required by law, by regulatory obligations applicable to financial institutions, or for operational purpose consistent with this Privacy Policy."
            ]
          },
          {
            title: "Use of Cookies and Tracking Technologies",
            content: [
              "GFL Holdings uses cookies, web beacons, and similar tools to:\n - Maintain session integrity\n - Personalize user experience\n - Analyze site usage\n - Improve performance and security",
              "You may modify your browser settings to refuse or delete cookies; however, doing so may limit your ability to use certain features of the platform."
            ]
          },
          {
            title: "Access and Correction of Your Information",
            content: [
              "You may review, update, or correct your personal information at any time by accessing your account settings or contacting customer support. Under GDPR, you may also request:\n - Data portability\n - Restriction of processing\n - Deletion of certain information (\"right to be forgotten\")\n - A copy of your stored data\nRequests will be processed within legally required timeframes."
            ]
          },
          {
            title: "Changes to This Privacy Policy",
            content: [
              "GFL Holdings reserves the right to update this Privacy Policy at any time. Any changes will be posted on our website with the updated effective date. Continued use of our services after changes are posted constitutes acceptance of the revised policy."
            ]
          },
          {
            title: "Contact Information",
            content: [
              "If you have questions regarding this Privacy Policy, data protection practices, or wish to make a request under GDPR or the UK Data Protection Act, you may contact us at:",
              "privacy@gflholdings.uk",
              "GFL Holdings Data Protection Office",
              "London, United Kingdom"
            ]
          }
        ],
        subscription: [
          {
            title: "Terms of Service\nUpdated December 2, 2025",
            content: [
              "GFL Holdings, Inc., a [State] Corporation (“GFL,” “the Company,” “we,” or “us”) operates a web-based lending and investment platform (the “Service”). By accessing or using the GFL website at gflholdings.com (including any subdomain thereof) (the “Site”), you (the “User”) signify that you have read, understand and agree to be bound by these Terms of Service and Use (“Terms of Use”), regardless of whether you are a registered member of the Service. In addition to these Terms of Use, you may enter into other agreements with us or others that govern your use of the Service or related services. If there is any contradiction between these Terms of Use and another agreement you enter into applicable to specific aspects of the Service, the other agreement shall take precedence with respect to those specific aspects. As used herein, “Users” means anyone who accesses and/or uses the Site."
            ]
          },
          {
            title: "1. Changes to These Terms of Service",
            content: [
              "We may revise these Terms of Service from time to time. If we do so, we will post the revised Terms on the Site and indicate at the top of the page the date these Terms were last revised. Your continued use of the Service or the Site following the posting of revised Terms constitutes your acceptance of the new Terms."
            ]
          },
          {
            title: "2. Payment & Crypto Processing; Third-Party Services",
            content: [
              "GFL may use one or more third-party service providers for payment processing, funds transfer, custody, and related services (each a “Third-Party Payment Provider”). These may include traditional payment processors, banking partners, and digital asset custodians or on/off ramps for cryptocurrencies. By buying, selling, transferring, or otherwise transacting through GFL, you agree to be bound by the terms of any Third-Party Payment Provider we use and you authorize GFL to share any information and payment instructions you provide with those providers as reasonably necessary to complete transactions. We may also utilize blockchain networks and smart contracts for tokenized instruments; transactions executed on public blockchains are irreversible and may be visible on-chain."
            ]
          },
          {
            title: "3. Crypto Transactions; Tokenized Instruments; Risks",
            content: [
              "a. Crypto Transactions. GFL supports certain transactions denominated in, transacted with, or settled using cryptocurrencies, stablecoins, or other digital assets (collectively “Crypto Assets”). Crypto Asset transactions are subject to market volatility, regulatory uncertainty, technical risks, custody risks, and potential loss. You acknowledge that Crypto Assets are not legal tender in many jurisdictions and that prices can be highly volatile.",
              "b. Tokenized Securities and Notes. GFL may offer tokenized versions of loan participations, promissory notes, or other investment instruments. Tokenized instruments may be treated as securities under applicable laws. The availability of tokenized instruments to you will depend on your eligibility, jurisdictional restrictions, and any representations you make to us.",
              "c. Irreversibility and Finality. Transactions executed on a blockchain may be irreversible. GFL has limited or no ability to reverse an on-chain transaction once it is confirmed. You are responsible for ensuring transaction addresses and parameters are correct.",
              "d. Custody. Where GFL or a third-party custodian holds Crypto Assets on your behalf, those assets may be held in pooled custody arrangements, cold storage, or other custody solutions. Different custody models carry different risks; please review any separate custody terms.",
              "e. AML/KYC and Sanctions. Crypto Asset transactions are subject to anti-money laundering (AML), know-your-customer (KYC), sanctions screening, and other compliance reviews. GFL may refuse, block, or reverse transactions, freeze accounts, or close accounts to comply with applicable law or our policies."
            ]
          },
          {
            title: "4. Mobile Authorization",
            content: [
              "You authorize your wireless carrier to disclose information about your account and device, if available, to GFL or its service providers for the duration of your business relationship solely to help us identify you and prevent fraud. See our Privacy Policy for details."
            ]
          },
          {
            title: "5. Securities and Regulatory Matters",
            content: [
              "Notwithstanding anything to the contrary in these Terms of Use, nothing shall be deemed a waiver of rights or protections that are not waivable under applicable federal or state securities laws. To the extent GFL offers investment opportunities that qualify as securities, such offerings will be governed by separate purchase agreements, offering documents, subscription agreements, and applicable securities laws. Tokenized instruments may be treated as securities and subject to registration requirements or exemptions."
            ]
          },
          {
            title: "6. Eligibility",
            content: [
              "The Site and Service are intended for Users who are 18 years of age or older (or the age of majority in your jurisdiction). By using the Service, you represent and warrant that you meet all eligibility requirements and that any information you provide is accurate. If you violate these Terms or any agreement with us, GFL may suspend or terminate your account, delete or remove content, and/or bar you from accessing the Site at any time without notice."
            ]
          },
          {
            title: "7. Registration Data; Account Security",
            content: [
              "You agree to (a) provide accurate, current, and complete information during registration (“Registration Data”); (b) maintain the security of your password and account credentials; (c) promptly update Registration Data to keep it accurate and current; and (d) be fully responsible for all use of your account and for any actions taken using your account. Do not share private keys or recovery phrases with anyone. GFL will never ask you to send your private keys or seed phrase via email or chat."
            ]
          },
          {
            title: "8. Proprietary Right in Site Content; Limited License",
            content: [
              "All content on the Site (the “Site Content”), including but not limited to designs, text, graphics, pictures, video, information, software, music, and other files, and their selection and arrangement, are the proprietary property of GFL or its licensors. You are granted a limited, non-exclusive, revocable license to access and use the Site solely for your personal, non-commercial purposes, provided you keep all copyright and proprietary notices intact. Except for your own User Content, you may not republish Site Content without our prior written permission."
            ]
          },
          {
            title: "9. Trademarks",
            content: [
              "“GFL,” “GFL Holdings,” and other Company graphics, logos, and service names are trademarks or trade dress of the Company. They may not be used without our prior written permission."
            ]
          },
          {
            title: "10. User Representations; Prohibited Uses",
            content: [
              "You represent and warrant that you will not use the Service to upload, post, transmit, share, store, or otherwise make available content that is harmful, unlawful, defamatory, infringing, abusive, harassing, obscene, fraudulent, or otherwise objectionable. You agree not to:",
              "• Register for more than one account or an account on behalf of another person or entity.",
              "• Impersonate any person or entity or falsely state your affiliation.",
              "• Upload or post personal data of third parties without consent.",
              "• Use automated scripts, bots, or scraping tools against the Site.",
              "• Use the Service to engage in money transmission, money laundering, fraud, or sanction-evasion.",
              "GFL may remove or restrict content and suspend accounts for violations."
            ]
          },
          {
            title: "11. User Content",
            content: [
              "You are solely responsible for the content you post (“User Content”). By posting User Content you grant GFL an irrevocable, perpetual, non-exclusive, transferable, worldwide, royalty-free license to use, copy, modify, publicly display, distribute, and create derivative works of such User Content in connection with the Site and its promotion. If you remove User Content, this license will survive."
            ]
          },
          {
            title: "12. Review, Ratings, and Posts",
            content: [
              "Any reviews, ratings, or posts you submit must comply with these Terms and not misrepresent facts. GFL may moderate, edit, or remove submissions at its discretion."
            ]
          },
          {
            title: "13. Copyright Complaints (DMCA)",
            content: [
              "If you believe content on the Site infringes your copyright, send a notice including the following information to GFL’s designated agent: (a) a physical or electronic signature of the authorized person; (b) identification of the copyrighted work; (c) identification of the material claimed to be infringing and sufficient information to locate it; (d) contact information; (e) a statement of good-faith belief; and (f) a statement under penalty of perjury that the information is accurate and you are authorized to act. GFL will respond according to applicable law."
            ],
          },
          {
            title: "14. Repeat Infringer Policy",
            content: [
              "GFL reserves the right to terminate the accounts of repeat infringers in appropriate circumstances."
            ]
          },
          {
            title: "15. Links to Third-Party Sites and Content",
            content: [
              "The Site may contain links to third-party websites and content. GFL does not endorse or control third-party content and is not responsible for their accuracy or policies. Access third-party sites at your own risk."
            ]
          },
          {
            title: "16. Consent to Electronic Transactions and Disclosures",
            content: [
              "By using the Site you agree to transact business electronically and receive disclosures electronically (including tax forms or other regulatory forms). Electronic Disclosures will be provided via the Site and/or to the verified email address you provide."
            ]
          },
          {
            title: "17. Electronic Communications; Storage Requirements",
            content: [
              "Electronic communications and disclosures will be provided via our Site or email. You are responsible for maintaining hardware and software capable of receiving and retaining such communications.",
            ]
          },
          {
            title: "18. Communications Consent (e.g., TCPA)",
            content: [
              "You consent to receive calls, texts, and messages, including auto-dialed or pre-recorded calls, from GFL and our agents at numbers you provide. Message frequency may vary; carrier message and data rates may apply."
            ]
          },
          {
            title: "19. Crypto-Specific Disclosures & Warnings",
            content: [
              "a. No FDIC/ SIPC Coverage. Crypto Assets are not covered by FDIC or SIPC insurance. Custody or custody-like services provided by third parties may have separate protections—review those terms.",
              "b. Regulatory Risk. Laws governing Crypto Assets and tokenized securities vary and can change quickly. You should consult legal counsel about regulatory implications where you live.",
              "c. Transaction Fees; Network Delays. Blockchain transaction fees (gas) and network congestion may affect processing times and costs.",
              "d. Wallet Security. You are responsible for securing your wallets. Loss of private keys may result in permanent loss of access.",
            ]
          },
          {
            title: "20. AML/KYC, Sanctions, and Compliance",
            content: [
              "GFL is subject to AML, KYC, sanctions, and other regulatory requirements. You agree to provide identity verification materials and other information requested by GFL or its service providers. GFL may restrict, suspend, or terminate accounts and transactions to comply with laws or our policies.",
            ]
          },
          {
            title: "21. Disclaimers; No Investment Advice",
            content: [
              "THE SITE, SERVICE, AND SITE CONTENT ARE PROVIDED “AS IS” AND “AS AVAILABLE” WITHOUT WARRANTY OF ANY KIND. GFL DOES NOT GUARANTEE ACCURACY, TIMELINESS, OR COMPLETENESS. NONE OF THE CONTENT ON THE SITE CONSTITUTES INVESTMENT, TAX, LEGAL, OR FINANCIAL ADVICE. YOU SHOULD CONSULT YOUR OWN ADVISORS."
            ]
          },
          {
            title: "22. No Guarantee of Results",
            content: [
              "GFL makes no promises regarding returns, loan performance, liquidity, or capital preservation. Past performance is not indicative of future results."
            ]
          },
          {
            title: "23. Limitation on Liability",
            content: [
              "TO THE MAXIMUM EXTENT PERMITTED BY APPLICABLE LAW, GFL AND ITS AFFILIATES WILL NOT BE LIABLE FOR ANY INDIRECT, INCIDENTAL, CONSEQUENTIAL, SPECIAL, EXEMPLARY OR PUNITIVE DAMAGES, INCLUDING LOST PROFITS, LOSS OF DATA, OR LOSS OF USE ARISING OUT OF OR IN CONNECTION WITH THE SERVICE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGES. GFL’s TOTAL LIABILITY WILL BE LIMITED TO THE AMOUNT PAID BY YOU TO GFL FOR THE SERVICE DURING THE TERM OF MEMBERSHIP, BUT IN NO EVENT WILL THIS AMOUNT EXCEED $1000, EXCEPT WHERE PROHIBITED BY LAW."
            ]
          },
          {
            title: "24. Governing Law; Venue and Jurisdiction",
            content: [
              "These Terms are governed by the laws of the State of [State], without regard to conflict-of-law principles. To the extent permitted by law, disputes will be brought in the federal or state courts located in [County], [State]."
            ]
          },
          {
            title: "25. Indemnity",
            content: [
              "You agree to indemnify, defend, and hold harmless GFL, its officers, directors, employees, agents, and affiliates from any claims, liabilities, damages, losses, and expenses (including reasonable attorneys’ fees) arising out of your breach of these Terms, violation of law, or your use of the Service."
            ]
          },
          {
            title: "26. Submissions; Feedback",
            content: [
              "Any feedback, suggestions, or submissions you provide to GFL will be non-confidential and GFL may use them without compensation to you."
            ]
          },
          {
            title: "27. Severability; No Waiver; Entire Agreement",
            content: [
              "If any provision is held invalid, the remainder will remain in effect. GFL’s failure to act on a breach does not waive its rights. These Terms constitute the entire agreement between you and GFL regarding your use of the Site and Service."
            ]
          },
          {
            title: "28. Contact Information",
            content: [
              "GFL Holdings, Inc.",
              "Email: legal@gflholdings.com"
            ]
          },
          {
            title: "29. Miscellaneous",
            content: [
              "a. Additional Terms. Certain features, products, or offerings may be subject to additional terms (e.g., subscription services, token sales, loan agreements) which will be provided separately and govern that feature.",
              "b. Assignment. GFL may assign these Terms in connection with a merger, acquisition, or sale of assets. You may not assign your rights without GFL’s consent.",
              "c. Notices. Notices to you may be provided via email or posting on the Site.",
              "By accessing or using the Site or Service, you acknowledge that you have read, understand, and agree to be bound by these Terms of Use.",
              "GFL Holdings, Inc.",
              "Email: legal@gflholdings.com",
            ]
          }
        ]
      };

      setDocuments(generatedDocs);
    };

    loadDocs();
  }, []);

  return (
    <NavlinkStruct back_text="Rules" text1="Terms &" text2="Condition">
      <div className="container_ pt-10" id="terms">
        <h1 className="text-4xl font-bold">GFL Holdings Legal Essentials</h1>
        <h4 className="text-xl font-bold pt-5">Terms, Offers & Agreements</h4>
        <p className="text-lg pt-8">We’re thrilled to have you here! Below, you’ll find important information about our legal agreements and policies for our products. If you have any questions or concerns, our support team is here to help.</p>
        <div className={`flex gap-10 py-10 ${useWindowWidth() < 992 ? "flex-col p-5" : ""}`}>

          {/* LEFT MENU */}
          <div className={`flex gap-4 ${useWindowWidth() < 992 ? (useWindowWidth() < 768 ? "w-full justify-center items-center flex-col" : "w-full justify-around items-center flex-row") : "flex-col min-w-60"}`}>
            {leftMenu.map(item => (
              <button
                key={item.id}
                onClick={() => {
                  setActiveMenu(item.id);
                  setOpenDoc(null); // закрыть открытый документ при смене меню
                }}
                className={`flex justify-center h-12 items-center rounded-full border ${useWindowWidth() < 992 ? (useWindowWidth() < 768 ? "w-72" : "text-md min-w-48") : "text-lg"} font-medium transition px-2 ${
                  activeMenu === item.id
                    ? "bg-white text-black border-black"
                    : "bg-black text-white"
                }`}
              >
                {item.title}
              </button>
            ))}
          </div>

          {/* RIGHT MENU */}
          <div className="flex-1">
            {activeMenu == "terms" ? (
              <h2 className="text-2xl font-semibold mb-6">
                {leftMenu.find(item => item.id === activeMenu).subTitle}
              </h2>
            ) : null}

            <div className="flex flex-col">
              {activeMenu == "terms" ? 
                (documents["terms"].map((doc, index) => (
                  <div key={index} className="border-b py-4">
                    <button
                      className="flex justify-between items-center w-full text-left"
                      onClick={() =>
                        setOpenDoc(openDoc === index ? null : index)
                      }
                    >
                      <span className="flex items-center gap-2 text-lg">
                        <span
                          className={`transition-transform ${
                            openDoc === index ? "rotate-90" : "rotate-0"
                          }`}
                        >
                          ▶
                        </span>
                        {doc.title}
                      </span>
                    </button>

                    {openDoc === index && (
                      <div className="mt-3 text-gray-600 text-sm pl-8" style={{ whiteSpace: "pre-line" }}>
                        {doc.content}
                        <p></p>
                        <button onClick={() => setOpenDoc(null)} className="text-md text-black px-3 py-1 rounded-full mt-3 border border-black">Close <span className="text-red-500 font-bold">X</span></button>
                      </div>
                    )}
                  </div>
                ))) : (
                  <div>
                    {documents[activeMenu].map((doc, index) => (
                      <div key={index} className="mb-4">
                        <h2 className="text-lg font-semibold mb-3">{doc.title}</h2>
                        {doc.content.map((item, index1) => (
                          <p key={index1} className="text-sm text-gray-600 mb-3" style={{ whiteSpace: "pre-line" }}>{item}</p>
                        ))}
                      </div>
                    ))}
                    <div className="flex justify-start items-center cursor-pointer mt-12" onClick={() => window.scrollTo({ top: document.getElementById("terms").offsetTop, behavior: 'smooth' })}>
                      <div className="progress-wrap_ active-progress">
                        <svg
                          className="progress-circle svg-content"
                          width="100%"
                          height="100%"
                          viewBox="-1 -1 102 102"
                        >
                          <path
                            d="M50,1 a49,49 0 0,1 0,98 a49,49 0 0,1 0,-98"
                            style={{
                              strokeDasharray: `0, 100`,
                              strokeDashoffset: 0,
                              transition: "stroke-dashoffset 50ms linear"
                            }}
                          />
                        </svg>
                      </div>
                      <p className="text-md text-gray-500 ml-2">Scroll to top</p>
                    </div>
                  </div>
                )
              }
            </div>
          </div>
        </div>
      </div>
    </NavlinkStruct>
  );
}

export default Terms;
